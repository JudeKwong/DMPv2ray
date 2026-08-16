using DialogHostAvalonia;
using ServiceLib.ViewModels;
using v2rayN.Desktop.Common;

namespace v2rayN.Desktop.Views;

public partial class RoutingView : ReactiveUserControl<RoutingSettingViewModel>
{
    private RoutingRuleSettingViewModel? _ruleVm;

    public RoutingView()
    {
        InitializeComponent();
        DataContext = new RoutingSettingViewModel();

        WireRuleButtons();

        this.WhenActivated(disposables =>
        {
            cmbDomainStrategy.ItemsSource = Global.DomainStrategies;
            cmbDomainStrategy4Singbox.ItemsSource = Global.DomainStrategies4Sbox;

            this.OneWayBind(ViewModel, vm => vm.RoutingItems, v => v.lstRoutings.ItemsSource).DisposeWith(disposables);
            this.Bind(ViewModel, vm => vm.SelectedSource, v => v.lstRoutings.SelectedItem).DisposeWith(disposables);
            this.Bind(ViewModel, vm => vm.DomainStrategy, v => v.cmbDomainStrategy.SelectedValue).DisposeWith(disposables);
            this.Bind(ViewModel, vm => vm.DomainStrategy4Singbox, v => v.cmbDomainStrategy4Singbox.SelectedValue).DisposeWith(disposables);

            this.BindCommand(ViewModel, vm => vm.RoutingAdvancedAddCmd, v => v.btnRoutingAdd).DisposeWith(disposables);
            this.BindCommand(ViewModel, vm => vm.RoutingAdvancedRemoveCmd, v => v.btnRoutingRemove).DisposeWith(disposables);
            this.BindCommand(ViewModel, vm => vm.RoutingAdvancedSetDefaultCmd, v => v.btnRoutingSetDefault).DisposeWith(disposables);
            this.BindCommand(ViewModel, vm => vm.RoutingAdvancedImportRulesCmd, v => v.btnRoutingImport).DisposeWith(disposables);

            ViewModel.ShowYesNoInteraction.RegisterHandler(async interaction =>
            {
                var result = await UI.ShowYesNo(interaction.Input);
                interaction.SetOutput(result == ButtonResult.Yes);
            }).DisposeWith(disposables);

            this.WhenAnyValue(x => x.ViewModel.SelectedSource)
                .Subscribe(async _ => await LoadRulesAsync(ViewModel.SelectedSource?.Id))
                .DisposeWith(disposables);
        });
    }

    private void WireRuleButtons()
    {
        btnRuleAdd.Click += (s, e) => { if (_ruleVm != null) _ruleVm.RuleAddCmd.Execute().Subscribe(_ => AfterRuleChange()); };
        btnRuleRemove.Click += (s, e) => { if (_ruleVm != null) _ruleVm.RuleRemoveCmd.Execute().Subscribe(_ => AfterRuleChange()); };
        btnRuleUp.Click += (s, e) => { if (_ruleVm != null) _ruleVm.MoveUpCmd.Execute().Subscribe(_ => AfterRuleChange()); };
        btnRuleDown.Click += (s, e) => { if (_ruleVm != null) _ruleVm.MoveDownCmd.Execute().Subscribe(_ => AfterRuleChange()); };
        btnRuleImportFile.Click += (s, e) => { if (_ruleVm != null) _ruleVm.ImportRulesFromFileCmd.Execute().Subscribe(_ => AfterRuleChange()); };
        btnRuleImportClipboard.Click += (s, e) => { if (_ruleVm != null) _ruleVm.ImportRulesFromClipboardCmd.Execute().Subscribe(_ => AfterRuleChange()); };
        btnRuleImportUrl.Click += (s, e) => { if (_ruleVm != null) _ruleVm.ImportRulesFromUrlCmd.Execute().Subscribe(_ => AfterRuleChange()); };
    }

    private void AfterRuleChange()
    {
        _ = _ruleVm?.SaveCmd.Execute();
        _ = ViewModel.RefreshRoutingItems();
    }

    private async Task LoadRulesAsync(string? routingId)
    {
        _ruleVm = null;
        lstRules.ItemsSource = null;

        if (routingId.IsNullOrEmpty())
        {
            return;
        }
        var item = await AppManager.Instance.GetRoutingItem(routingId);
        if (item is null)
        {
            return;
        }

        var vm = new RoutingRuleSettingViewModel(item);
        _ruleVm = vm;

        vm.ShowYesNoInteraction.RegisterHandler(async interaction =>
        {
            var result = await UI.ShowYesNo(interaction.Input);
            interaction.SetOutput(result == ButtonResult.Yes);
        });
        vm.SetClipboardDataInteraction.RegisterHandler(async interaction =>
        {
            await AvaUtils.SetClipboardData(this, interaction.Input);
            interaction.SetOutput(RxVoid.Default);
        });
        vm.ReadTextFromClipboardInteraction.RegisterHandler(async interaction =>
        {
            var window = TopLevel.GetTopLevel(this) as Window;
            var result = window != null ? await AvaUtils.GetClipboardData(window) : null;
            interaction.SetOutput(result);
        });
        vm.BrowseRulesFileInteraction.RegisterHandler(async interaction =>
        {
            var fileName = await UI.OpenFileDialog(null);
            interaction.SetOutput(fileName);
        });

        lstRules.ItemsSource = vm.RulesItems;
        lstRules.SelectedItem = vm.SelectedSource;
    }
}


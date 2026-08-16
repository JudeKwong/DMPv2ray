using DialogHostAvalonia;
using ServiceLib.Handler;
using ServiceLib.Manager;
using ServiceLib.ViewModels;
using v2rayN.Desktop.Common;

namespace v2rayN.Desktop.Views;

public partial class SubscriptionView : ReactiveUserControl<SubSettingViewModel>
{
    private readonly MainWindowViewModel? _mainVm;

    public SubscriptionView() : this(null)
    {
    }

    public SubscriptionView(MainWindowViewModel? mainVm)
    {
        InitializeComponent();
        _mainVm = mainVm;
        DataContext = new SubSettingViewModel();

        if (_mainVm != null)
        {
            btnAddSub.Click += (s, e) =>
            {
                _mainVm.AddServerPickerCmd.Execute().Subscribe(_ => ViewModel.RefreshSubItems());
            };
        }

        this.WhenActivated(disposables =>
        {
            this.BindCommand(ViewModel, vm => vm.SubEditCmd, v => v.btnEditSub).DisposeWith(disposables);
            this.BindCommand(ViewModel, vm => vm.SubDeleteCmd, v => v.btnDeleteSub).DisposeWith(disposables);
            this.BindCommand(ViewModel, vm => vm.SubShareCmd, v => v.btnShareSub).DisposeWith(disposables);

            btnUpdateAll.Click += async (s, e) => await UpdateSubs(string.Empty, false);
            btnUpdateCurrent.Click += async (s, e) =>
            {
                if (ViewModel.SelectedSource?.Id.IsNullOrEmpty() != false)
                {
                    NoticeManager.Instance.Enqueue(ResUI.OperationFailed);
                    return;
                }
                await UpdateSubs(ViewModel.SelectedSource.Id, false);
            };

            ViewModel.ShowYesNoInteraction.RegisterHandler(async interaction =>
            {
                var result = await UI.ShowYesNo(interaction.Input);
                interaction.SetOutput(result == ButtonResult.Yes);
            }).DisposeWith(disposables);

            ViewModel.ShareSubInteraction.RegisterHandler(async interaction =>
            {
                var url = interaction.Input;
                if (url.IsNullOrEmpty())
                {
                    interaction.SetOutput(RxVoid.Default);
                    return;
                }
                var dialog = new QrcodeView(url);
                await DialogHost.Show(dialog);
                interaction.SetOutput(RxVoid.Default);
            }).DisposeWith(disposables);
        });
    }

    private async Task UpdateSubs(string subId, bool viaProxy)
    {

        Func<bool, string, Task> updateFunc = (success, msg) =>
        {
            NoticeManager.Instance.SendMessageEx(msg);
            return Task.CompletedTask;
        };
        await Task.Run(async () => await SubscriptionHandler.UpdateProcess(AppManager.Instance.Config, subId, viaProxy, updateFunc));
        await ViewModel.RefreshSubItems();
    }
}





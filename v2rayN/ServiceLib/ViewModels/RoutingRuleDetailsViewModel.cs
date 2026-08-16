namespace ServiceLib.ViewModels;

public partial class RoutingRuleDetailsViewModel : MyReactiveObject, ICloseable
{
    public event EventHandler? RequestClose;

    public IList<ComboItem> MatchTypes { get; } = [];
    public IList<ComboItem> Policies { get; } = [];

    [Reactive]
    public partial RulesItem SelectedSource { get; set; }

    [Reactive]
    public partial string Domain { get; set; }

    [Reactive]
    public partial ComboItem SelectedMatchType { get; set; }

    [Reactive]
    public partial ComboItem SelectedPolicy { get; set; }

    [Reactive]
    public partial string Remarks { get; set; }

    [Reactive]
    public partial string OutboundTag { get; set; }

    public ReactiveCommand<RxVoid, RxVoid> SaveCmd { get; }

    public RoutingRuleDetailsViewModel(RulesItem rulesItem)
    {
        _config = AppManager.Instance.Config;

        MatchTypes.Add(new() { ID = "prefix", Text = ResUI.RuleMatchDomainPrefix });
        MatchTypes.Add(new() { ID = "full", Text = ResUI.RuleMatchFullDomain });
        Policies.Add(new() { ID = "proxy", Text = ResUI.RulePolicyProxy });
        Policies.Add(new() { ID = "direct", Text = ResUI.RulePolicyDirect });

        SaveCmd = ReactiveCommand.CreateFromTask(async () =>
        {
            await SaveRulesAsync();
        });

        if (rulesItem.Id.IsNullOrEmpty())
        {
            rulesItem.Id = Utils.GetGuid(false);
            rulesItem.OutboundTag = Global.ProxyTag;
            rulesItem.Enabled = true;
        }
        SelectedSource = rulesItem;

        var firstDomain = SelectedSource.Domain?.FirstOrDefault() ?? string.Empty;
        if (firstDomain.StartsWith("full:"))
        {
            SelectedMatchType = MatchTypes[1];
            Domain = firstDomain.Length > 5 ? firstDomain[5..] : string.Empty;
        }
        else if (firstDomain.StartsWith("domain:"))
        {
            SelectedMatchType = MatchTypes[0];
            Domain = firstDomain.Length > 7 ? firstDomain[7..] : string.Empty;
        }
        else
        {
            SelectedMatchType = MatchTypes[0];
            Domain = Utils.List2String(SelectedSource.Domain, true);
        }
        SelectedPolicy = SelectedSource.OutboundTag == Global.DirectTag ? Policies[1] : Policies[0];
        Remarks = SelectedSource.Remarks ?? string.Empty;
        OutboundTag = SelectedSource.OutboundTag ?? string.Empty;
    }

    private async Task SaveRulesAsync()
    {
        var domain = Domain?.Trim();
        if (domain.IsNullOrEmpty())
        {
            NoticeManager.Instance.Enqueue(ResUI.RuleDomainRequired);
            return;
        }

        var prefix = SelectedMatchType?.ID == "full" ? "full:" : "domain:";
        SelectedSource.Domain = [prefix + domain];
        SelectedSource.Ip = null;
        SelectedSource.Process = null;
        SelectedSource.Protocol = null;
        SelectedSource.Port = null;
        SelectedSource.Network = null;
        SelectedSource.InboundTag = null;
        SelectedSource.OutboundTag = SelectedPolicy?.ID == "direct" ? Global.DirectTag : Global.ProxyTag;
        SelectedSource.Remarks = Remarks.IsNullOrEmpty() ? domain : Remarks;
        SelectedSource.Enabled = true;
        SelectedSource.RuleType = null;

        RequestClose?.Invoke(this, EventArgs.Empty);
        await Task.CompletedTask;
    }
}

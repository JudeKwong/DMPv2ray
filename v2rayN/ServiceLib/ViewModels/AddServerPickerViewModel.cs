using ReactiveUI;
using System.Collections.ObjectModel;
using ServiceLib.Base;
using ServiceLib.Enums;
using ServiceLib.Models.Dto;
using ServiceLib.Resx;

namespace ServiceLib.ViewModels;

public partial class AddServerPickerViewModel : MyReactiveObject, ICloseable
{
    public event EventHandler? RequestClose;

    public ObservableCollection<ComboItem> AddTypes { get; } = [];

    public ObservableCollection<ComboItem> ConfigTypes { get; } = [];

    [Reactive]
    public partial ComboItem SelectedAddType { get; set; }

    [Reactive]
    public partial ComboItem SelectedConfigType { get; set; }

    [Reactive]
    public partial bool IsSubscription { get; set; }

    [Reactive]
    public partial string Remarks { get; set; }

    [Reactive]
    public partial string ShareLink { get; set; }

    public ReactiveCommand<RxVoid, RxVoid> OkCmd { get; }

    public AddServerPickerViewModel()
    {
        AddTypes.Add(new ComboItem { ID = "server", Text = ResUI.LabServer });
        AddTypes.Add(new ComboItem { ID = "subscription", Text = ResUI.LabSubscription });
        SelectedAddType = AddTypes[0];

        foreach (var type in new[]
        {
            EConfigType.VMess,
            EConfigType.VLESS,
            EConfigType.Shadowsocks,
            EConfigType.Trojan,
            EConfigType.Hysteria2,
            EConfigType.WireGuard,
            EConfigType.SOCKS,
            EConfigType.HTTP,
            EConfigType.TUIC,
            EConfigType.Anytls,
            EConfigType.Naive,
        })
        {
            ConfigTypes.Add(new ComboItem { ID = type.ToString(), Text = type.ToString() });
        }
        SelectedConfigType = ConfigTypes.FirstOrDefault();

        this.WhenAnyValue(x => x.SelectedAddType)
            .Subscribe(_ => IsSubscription = SelectedAddType?.ID == "subscription");

        OkCmd = ReactiveCommand.Create(() => RequestClose?.Invoke(this, EventArgs.Empty));
    }

    public EConfigType GetSelectedConfigType()
    {
        return Enum.TryParse<EConfigType>(SelectedConfigType?.ID, out var type) ? type : EConfigType.VMess;
    }
}

using ServiceLib.ViewModels;

namespace v2rayN.Desktop.Views;

public partial class SettingsView : UserControl
{
    public event Action? BackupAndRestoreRequested;
    public event Action? ExitRequested;
    public event Action? UWPSettingRequested;

    public SettingsView()
    {
        InitializeComponent();

        btnBackupAndRestore.Click += (s, e) => BackupAndRestoreRequested?.Invoke();
        btnExit.Click += (s, e) => ExitRequested?.Invoke();
        btnUWP.Click += (s, e) => UWPSettingRequested?.Invoke();
    }
}

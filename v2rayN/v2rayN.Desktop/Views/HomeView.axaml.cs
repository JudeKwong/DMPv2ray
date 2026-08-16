using Avalonia.Controls;
using ServiceLib.ViewModels;

namespace v2rayN.Desktop.Views;

public partial class HomeView : UserControl
{
    public HomeView()
    {
        InitializeComponent();
        DataContext = StatusBarViewModel.Instance;
    }
}

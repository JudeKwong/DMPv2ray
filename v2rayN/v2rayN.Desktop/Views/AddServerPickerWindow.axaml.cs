using v2rayN.Desktop.Base;

namespace v2rayN.Desktop.Views;

public partial class AddServerPickerWindow : WindowBase<AddServerPickerViewModel>
{
    public AddServerPickerWindow()
    {
        InitializeComponent();

        btnCancel.Click += (s, e) => Close();

        this.WhenActivated(disposables =>
        {
            this.BindCommand(ViewModel, vm => vm.OkCmd, v => v.btnOk).DisposeWith(disposables);
        });
    }
}

using System.Windows.Input;

namespace TestMauiTabs;

public partial class Page2
{
    public Page2()
    {
        InitializeComponent();
    }

    public ICommand ToolbarCommand => new Command(() => DisplayAlert("Clicked in Page 2", string.Empty, "OK"));
    
}
using System.Windows.Input;

namespace TestMauiTabs;

public partial class Page3
{
    public Page3()
    {
        InitializeComponent();
    }
    
    public ICommand ToolbarCommand => new Command(() => DisplayAlert("Clicked in Page 3", string.Empty, "OK"));

}
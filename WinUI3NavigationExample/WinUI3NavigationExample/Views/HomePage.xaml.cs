using Microsoft.UI.Xaml.Controls;
using WinUI3NavigationExample.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3NavigationExample.Views
{

    public sealed partial class HomePage : Page
    {
        public HomeViewModel ViewModel { get; } = new();

        public HomePage()
        {
            InitializeComponent();
            this.DataContext = ViewModel;
        }
    }
}

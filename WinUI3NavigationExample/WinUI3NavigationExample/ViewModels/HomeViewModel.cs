using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace WinUI3NavigationExample.ViewModels;

public partial class HomeViewModel: ObservableObject
{
    [ObservableProperty] private string name = "Home Page Name";
    [ObservableProperty] private bool buttonEnabled = true;

}
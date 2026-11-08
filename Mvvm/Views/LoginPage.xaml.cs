
using Mvvm.Services;
using Mvvm.ViewModels;

namespace Mvvm.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginPageVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
using Mvvm.Services;
using Mvvm.ViewModels;

namespace Mvvm.Views;

public partial class Adduser : ContentPage
{
    public Adduser(AddUserMvvm vm)
    { 
        InitializeComponent();
        BindingContext = vm;
    }
}
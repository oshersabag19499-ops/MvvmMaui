using Mvvm.ViewModels;

namespace Mvvm.Views;

public partial class UserList : ContentPage
{
    public UserList(UserListvm vm)
	{
        InitializeComponent();
        BindingContext = vm;
    }
}
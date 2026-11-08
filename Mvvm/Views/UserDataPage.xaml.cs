namespace Mvvm.Views;

public partial class UserDataPage : ContentPage
{
	public UserDataPage(UserDataPage vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}
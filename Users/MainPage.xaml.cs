using Users.ViewModels;

namespace Users;

public partial class MainPage : ContentPage
{
	public MainPage(UsersViewModel userModelView)
	{
		InitializeComponent();
		BindingContext = userModelView;
	}
}


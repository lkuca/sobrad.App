using sobrad.Views;

namespace sobrad;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new FriendsListPage());
	}
}

namespace sobrad.Views;


[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class FriendsListPage : ContentPage
{
	public FriendsListPage()
	{
		InitializeComponent();
		BindingContext = new FriendsListViewModel() {  Navigation = this.Navigation };
	}
}
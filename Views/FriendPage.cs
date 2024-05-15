using sobrad.ViewModels;

namespace sobrad.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public class FriendPage : ContentPage
{
	public FriendViewModel ViewModel { get; private set; }
	public FriendPage(FriendViewModel vm)
	{
		ViewModel= vm;
		this.BindingContext = ViewModel;
	}
}
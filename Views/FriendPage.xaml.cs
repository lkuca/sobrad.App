using sobrad.ViewModels;

namespace sobrad.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class FriendPage : ContentPage
{
    public FriendViewModel ViewModel { get; private set; }
    public FriendPage(FriendViewModel vm)
    {
        InitializeComponent();
        ViewModel = vm;
        this.BindingContext = ViewModel;
    }
}

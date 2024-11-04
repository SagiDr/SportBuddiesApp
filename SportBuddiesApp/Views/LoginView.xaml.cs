using SportBuddiesApp.ViewModels;

namespace SportBuddiesApp.Views;

public partial class LoginView : ContentPage
{
    public LoginView(LoginViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}
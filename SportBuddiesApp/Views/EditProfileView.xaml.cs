using SportBuddiesApp.ViewModels;

namespace SportBuddiesApp.Views;

public partial class EditProfileView : ContentPage
{
    public EditProfileView(EditProfileViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}
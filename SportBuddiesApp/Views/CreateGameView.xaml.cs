namespace SportBuddiesApp.Views;
using Microsoft.Maui.Controls;
using SportBuddiesApp.ViewModels;

public partial class CreateGameView : ContentPage
{
	public CreateGameView(CreateGameViewModel vm)
	{
		this.BindingContext = vm;	
        InitializeComponent();
	}
}
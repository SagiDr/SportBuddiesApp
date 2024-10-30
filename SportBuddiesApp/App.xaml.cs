using SportBuddiesApp.Models;
using SportBuddiesApp.Services;
//using SportBuddiesApp.Views;

namespace SportBuddiesApp
{
    public partial class App : Application
    {
        public User? LoggedInUser { get; set; }
        public App()
        {

            LoggedInUser = null;
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}

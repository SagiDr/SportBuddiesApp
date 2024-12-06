using SportBuddiesApp.Models;
using SportBuddiesApp.Services;
using SportBuddiesApp.Views;

namespace SportBuddiesApp
{
    public partial class App : Application
    { 
        public User? LoggedInUser { get; set; }
        private SportBuddiesWebAPIProxy proxy;
        public App(IServiceProvider serviceProvider, SportBuddiesWebAPIProxy proxy)
        {
            //LoadBasicDataFromServer();
            //Start with the Login View
            this.proxy = proxy;
            InitializeComponent();
            LoggedInUser = null;
            MainPage = new NavigationPage(serviceProvider.GetService<LoginView>());
        }

        //private async void LoadBasicDataFromServer()
        //{
        //    //List<UrgencyLevel>? levels = await this.proxy.GetUrgencyLevels();
        //    if (levels != null)
        //    {
        //        UrgencyLevels.Clear();
        //        foreach (UrgencyLevel level in levels)
        //        {
        //            UrgencyLevels.Add(level);
        //        }
        //    }
        //}
    }
}

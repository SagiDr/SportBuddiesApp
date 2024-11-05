using SportBuddiesApp.Models;
using SportBuddiesApp.Services;
using SportBuddiesApp.Views;

namespace SportBuddiesApp
{
    public partial class App : Application
    { //Application level variables
        public User? LoggedInUser { get; set; }
        //public List<UrgencyLevel> UrgencyLevels { get; set; } = new List<UrgencyLevel>();
        private SportBuddiesWebAPIProxy proxy;
        public App(IServiceProvider serviceProvider, SportBuddiesWebAPIProxy proxy)
        {
            this.proxy = proxy;
            InitializeComponent();
            LoggedInUser = null;
            //LoadBasicDataFromServer();
            //Start with the Login View
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

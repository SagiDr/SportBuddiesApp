using SportBuddiesApp.ViewModels;
using SportBuddiesApp.Views;

    
namespace SportBuddiesApp
{
    public partial class AppShell : Shell
    {
        public AppShell(AppShellViewModel vm)
        {
            this.BindingContext = vm;
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("login", typeof(LoginView));
            Routing.RegisterRoute("register", typeof(RegisterView));
        }
    }
}

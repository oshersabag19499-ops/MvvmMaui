using Mvvm.Views;

namespace Mvvm
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterPages();
        }
        private void RegisterPages()
        {
            Routing.RegisterRoute("UserData", typeof(UserDataPage));
        }
    }
}

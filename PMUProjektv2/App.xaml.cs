using Microsoft.Maui.Controls;

namespace PMUProjektv2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

        }
    }
}

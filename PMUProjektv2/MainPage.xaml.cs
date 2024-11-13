using PMUProjektv2;

namespace PMUProjektv2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCalculatePeriodButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PeriodPage());
        }

        private async void OnCalculateMassButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MassPage());
        }
    }
}

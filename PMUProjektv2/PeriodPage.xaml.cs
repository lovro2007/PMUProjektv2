using Microsoft.Maui.Controls;

namespace PMUProjektv2
{
    public partial class PeriodPage : ContentPage
    {
        public PeriodPage()
        {
            InitializeComponent();
        }

        private void OnCalculatePeriodClicked(object sender, EventArgs e)
        {
            if (double.TryParse(frequencyEntry.Text, out double frequency))
            {
                double period = 1 / frequency;
                periodResultLabel.Text = $"Period: {period} seconds";
            }
            else
            {
                periodResultLabel.Text = "Please enter a valid frequency!";
            }
        }
    }
}

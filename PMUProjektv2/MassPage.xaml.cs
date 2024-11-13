using Microsoft.Maui.Controls;

namespace PMUProjektv2
{
    public partial class MassPage : ContentPage
    {
        public MassPage()
        {
            InitializeComponent();
        }

        private void OnCalculateMassClicked(object sender, EventArgs e)
        {
            if (double.TryParse(densityEntry.Text, out double density) &&
                double.TryParse(volumeEntry.Text, out double volume))
            {
                // Mass = Density * Volume
                double mass = density * volume;
                massResultLabel.Text = $"Mass: {mass} kg";
            }
            else
            {
                massResultLabel.Text = "Please enter valid density and volume values!";
            }
        }
    }
}

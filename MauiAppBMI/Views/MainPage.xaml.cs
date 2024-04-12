using System.Reflection;

namespace MauiAppBMI.Views
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(weight_inp.Text);
            double height = Convert.ToDouble(height_inp.Text);
            double bmi = (weight / (height * height)) * 703;
            BMI.Text = $"Your BMI is {bmi}";
        }
        
       
    }
}
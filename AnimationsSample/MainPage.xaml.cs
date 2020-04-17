using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimationsSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Card3D_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Card3DPage());
        }

        async void Shake_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ProfileShakePage());
        }

        async void Scale2X_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ScaleTo2xPage());
        }

        async void Bounce_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MacIconBouncePage());
        }

        async void Gradient_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PancakeGradientShiftsPage());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimationsSample
{
    public partial class PancakeGradientShiftsPage : ContentPage
    {
        private bool _isAnimating;

        public PancakeGradientShiftsPage()
        {
            InitializeComponent();
        }

        async void StartStopAnimation_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!_isAnimating)
            {
                _isAnimating = true;
                status.Text = "RUNNING";

                await pancake.ColorTo(Color.FromHex("#8845b8"), Color.FromHex("#c23569"), c => pancake.BackgroundGradientStartColor = c, 5000, Easing.Linear);
                await pancake.ColorTo(Color.FromHex("#f52e33"), Color.FromHex("#ff9e4f"), c => pancake.BackgroundGradientEndColor = c, 5000, Easing.Linear);
                await pancake.ColorTo(Color.FromHex("#c23569"), Color.FromHex("#8845b8"), c => pancake.BackgroundGradientStartColor = c, 5000, Easing.Linear);
                await pancake.ColorTo(Color.FromHex("#ff9e4f"), Color.FromHex("#f52e33"), c => pancake.BackgroundGradientEndColor = c, 5000, Easing.Linear);

                status.Text = "DONE";
                _isAnimating = false;
            }
            else
            {
                _isAnimating = false;
                status.Text = string.Empty;
                ViewExtensions.CancelAnimations(pancake);
            }
        }
    }
}

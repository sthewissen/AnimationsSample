using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimationsSample
{
    public partial class Card3DPage : ContentPage
    {
        private bool _isAnimating;

        public Card3DPage()
        {
            InitializeComponent();
        }

        async void StartStopAnimation_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!_isAnimating)
            {
                _isAnimating = true;

                await Task.WhenAll(
                  card.RotateTo(40, 60000),
                  card.RotateXTo(40, 60000),
                  card.RotateYTo(40, 60000)
                );
            }
            else
            {
                _isAnimating = false;
                ViewExtensions.CancelAnimations(card);
            }
        }
    }
}

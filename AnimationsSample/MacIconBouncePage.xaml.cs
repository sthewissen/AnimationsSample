using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AnimationsSample
{
    public partial class MacIconBouncePage : ContentPage
    {
        private bool _isAnimating;

        public MacIconBouncePage()
        {
            InitializeComponent();
        }

        void StartStopAnimation_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!_isAnimating)
            {
                _isAnimating = true;

                new Animation {
                    { 0, 0.25, new Animation (v => rainbow.TranslationY = v, 0, -40) },
                    { 0.25, .5, new Animation (v => rainbow.TranslationY = v, -40, 0, easing: Easing.BounceOut) }
                }
                .Commit(this, "AppleIconBounceChildAnimations", length: 1000, repeat: () => true);
            }
            else
            {
                _isAnimating = false;
                this.AbortAnimation("AppleIconBounceChildAnimations");
            }
        }
    }
}

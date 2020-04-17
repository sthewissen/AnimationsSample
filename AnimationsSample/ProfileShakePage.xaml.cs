using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AnimationsSample
{
    public partial class ProfileShakePage : ContentPage
    {
        private bool _isAnimating;

        public ProfileShakePage()
        {
            InitializeComponent();
        }

        void StartStopAnimation_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!_isAnimating)
            {
                _isAnimating = true;

                new Animation {
                    { 0, 0.125, new Animation (v => profile.TranslationX = v, 0, -13) },
                    { 0.125, 0.250, new Animation (v => profile.TranslationX = v, -13, 13) },
                    { 0.250, 0.375, new Animation (v => profile.TranslationX = v, 13, -11) },
                    { 0.375, 0.5, new Animation (v => profile.TranslationX = v, -11, 11) },
                    { 0.5, 0.625, new Animation (v => profile.TranslationX = v, 11, -7) },
                    { 0.625, 0.75, new Animation (v => profile.TranslationX = v, -7, 7) },
                    { 0.75, 0.875, new Animation (v => profile.TranslationX = v, 7, -5) },
                    { 0.875, 1, new Animation (v => profile.TranslationX = v, -5, 0) }
                }
                .Commit(this, "AppleShakeChildAnimations", length: 500, easing: Easing.Linear, finished: (x, y) => _isAnimating = false);
            }
        }
    }
}

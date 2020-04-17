using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AnimationsSample
{
    public partial class ScaleTo2xPage : ContentPage
    {
        private Animation _animation;
        private bool _isAnimating;

        public ScaleTo2xPage()
        {
            InitializeComponent();
        }

        void StartStopAnimation_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!_isAnimating)
            {
                _isAnimating = true;

                _animation = new Animation(v => image.Scale = v, 1, 2);
                _animation.Commit(this, "ScaleIt", length: 2000, easing: Easing.Linear,
                    finished: (v, c) => image.Scale = 1, repeat: () => true);
            }
            else
            {
                _isAnimating = false;
                this.AbortAnimation("ScaleIt");
            }
        }
    }
}

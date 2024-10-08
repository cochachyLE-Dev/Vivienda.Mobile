﻿using Android.Graphics;
using Android.Views;

using Vivienda.Mobile.Droid.Effects;

using System;
using System.ComponentModel;
using System.Diagnostics;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(RoundCornersEffect), nameof(RoundCornersEffect))]
namespace Vivienda.Mobile.Droid.Effects
{
    public class RoundCornersEffect : PlatformEffect
    {
        private Android.Views.View View => Control ?? Container;
        protected override void OnAttached()
        {
            try
            {
                
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        protected override void OnDetached()
        {
            try
            {
                View.OutlineProvider = Android.Views.ViewOutlineProvider.Background;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == Mobile.Effects.RoundCornersEffect.CornerRadiusProperty.PropertyName)
                SetCornerRadius();
            //base.OnElementPropertyChanged(args);
        }
        private void PrepareContainer()
        {
            View.ClipToOutline = true;
        }
        private void SetCornerRadius()        
        {
            var cornerRadius = Mobile.Effects.RoundCornersEffect.GetCornerRadius(Element) * GetDensity();
            View.OutlineProvider = new RoundedOutlineProvider(cornerRadius);
        }

        private static double GetDensity() => DeviceDisplay.MainDisplayInfo.Density;

        private class RoundedOutlineProvider : Android.Views.ViewOutlineProvider
        {
            private readonly double _radius;
            public RoundedOutlineProvider(double radius)
            {
                _radius = radius;
            }
            public override void GetOutline(Android.Views.View view, Outline outline)
            {
                outline.SetRoundRect(0, 0, view.Width, view.Height, (float)_radius);
            }
        }
    }
}
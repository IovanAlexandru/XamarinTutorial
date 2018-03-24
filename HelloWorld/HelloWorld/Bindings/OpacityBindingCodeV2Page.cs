using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloWorld.Bindings
{
    public class OpacityBindingCodeV2Page : ContentPage
    {
        public OpacityBindingCodeV2Page()
        {
            Label label = new Label()
            {
                Text = "Opacity binding demo",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Slider slider = new Slider()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Define Binding object with source object and property.
            // V1
            //Binding binding = new Binding()
            //{
            //    Source = slider,
            //    Path="Value"
            //};
            // V2
            Binding binding = Binding.Create<Slider>(src => src.Value);
            binding.Source = slider;

            // Set the binding context. Target is Label; source is slider
            label.SetBinding(Label.OpacityProperty, binding);

            Padding = new Thickness(10, 0);
            Content = new StackLayout()
            {
                Children =
                {
                    label, slider
                }
            };
        }
    }
}

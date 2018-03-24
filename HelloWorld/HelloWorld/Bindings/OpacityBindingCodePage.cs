using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloWorld.Bindings
{
    public class OpacityBindingCodePage: ContentPage
    {
        public OpacityBindingCodePage()
        {
            Label label = new Label()
            {
                Text="Opacity binding demo",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Slider slider =new Slider()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Set the binding context. Target is Label; source is slider
            label.BindingContext = slider;
            label.SetBinding(Label.OpacityProperty, nameof(Slider.Value));

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

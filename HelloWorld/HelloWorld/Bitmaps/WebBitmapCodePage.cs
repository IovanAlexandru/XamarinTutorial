using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloWorld.Bitmaps
{
    public class WebBitmapCodePage : ContentPage
    {
        public WebBitmapCodePage()
        {
            //string uri = "https://developer.xamarin.com/demo/IMG_1415.JPG";
            //Content = new Image
            //{
            //    Source = ImageSource.FromUri(new Uri(uri))
            //};

            Content = new Image
            {
                //AspectFit — the default
                //Fill — stretches without preserving the aspect ratio
                //AspectFill — preserves the aspect ratio but crops the image
                Aspect = Aspect.AspectFill,
                /// UriImageSource offers caching capabilities.
                Source = new UriImageSource
                {
                    CachingEnabled = true,
                    CacheValidity = TimeSpan.MaxValue,
                    Uri = new Uri("https://developer.xamarin.com/demo/IMG_1415.JPG")
                }
            };
        }
    }
}

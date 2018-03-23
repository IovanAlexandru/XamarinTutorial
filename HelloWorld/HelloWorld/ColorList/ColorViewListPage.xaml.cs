using System;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.ColorList
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ColorViewListPage : ContentPage
	{
		public ColorViewListPage ()
		{
			InitializeComponent ();
            Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
            {
                return false;
            });
		}

	    private async void ColorView_OnClicked(object sender, EventArgs e)
	    {
	        var target = sender as ColorView;
	        await DisplayAlert("Alert", $"You tapped on: ({target.Color.A}, {target.Color.R}, {target.Color.G}, {target.Color.B})", "OK");
	    }

	    private async void ColorView_OnDoubleTapped(object sender, TappedEventArgs e)
	    {
	        var target = sender as ColorView;
	        await DisplayAlert("Alert", $"You double tapped on: ({target.Color.A}, {target.Color.R}, {target.Color.G}, {target.Color.B})", "OK");
        }
	}
}
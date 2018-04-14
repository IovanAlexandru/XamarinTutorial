using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2Demo : ContentPage
    {
		public Page2Demo ()
		{
			InitializeComponent();
		    Title = nameof(Page2Demo);
		}

	    private async void OnGoBack(object sender, EventArgs e)
	    {
	        await Navigation.PopAsync();
	    }
	}
}
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Bindings
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebviewDemo : ContentPage
	{
		public WebviewDemo()
		{
			InitializeComponent();
		}

	    private void OnGoBackClicked(object sender, EventArgs e)
	    {
	        webView.GoBack();
	    }

	    private void OnGoForwardClicked(object sender, EventArgs e)
	    {
	        webView.GoForward();
	    }
	}
}
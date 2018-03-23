using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Styles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DynamicStylesPage : ContentPage
	{
		public DynamicStylesPage ()
		{
			InitializeComponent ();
		}

	    private void OnButton1Clicked(object sender, EventArgs e)
	    {
	        Resources["buttonStyle"] = Resources["buttonStyle1"];
	    }

	    private void OnButton2Clicked(object sender, EventArgs e)
	    {
	        Resources["buttonStyle"] = Resources["buttonStyle2"];
        }

	    private void OnButton3Clicked(object sender, EventArgs e)
	    {
	        Resources["buttonStyle"] = Resources["buttonStyle3"];
        }

	    private void OnResetButtonClicked(object sender, EventArgs e)
	    {
	        Resources["buttonStyle"] = null;
        }
    }
}
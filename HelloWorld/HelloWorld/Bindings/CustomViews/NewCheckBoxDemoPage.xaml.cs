using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Bindings.CustomViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewCheckBoxDemoPage : ContentPage
	{
		public NewCheckBoxDemoPage ()
		{
			InitializeComponent ();
		}

	    private void OnItalicCheckBoxChanged(object sender, bool isChecked)
	    {
	        if (isChecked)
	        {
	            label.FontAttributes |= FontAttributes.Italic;
	        }
	        else
	        {
	            label.FontAttributes &= ~FontAttributes.Italic;
	        }
	    }

	    private void OnBoldCheckBoxChanged(object sender, bool isChecked)
	    {
	        if (isChecked)
	        {
	            label.FontAttributes |= FontAttributes.Bold;
	        }
	        else
	        {
	            label.FontAttributes &= ~FontAttributes.Bold;
	        }
	    }
	}
}
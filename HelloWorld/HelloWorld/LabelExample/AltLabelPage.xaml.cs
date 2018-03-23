using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.LabelExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AltLabelPage : ContentPage
	{
		public AltLabelPage ()
		{
			InitializeComponent ();
		    wordCountLabel.Text = countedLabel.WordCount + " words";
		}
	}
}
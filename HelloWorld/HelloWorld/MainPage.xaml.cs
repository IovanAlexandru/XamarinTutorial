using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
	    public static int Counter = 0;

		public MainPage()
		{
			InitializeComponent();
		}

	    protected override void OnAppearing()
	    {
	        Counter++;
	        DisplayCountLbl.Text = Counter.ToString();
            base.OnAppearing();
	    }
	}
}

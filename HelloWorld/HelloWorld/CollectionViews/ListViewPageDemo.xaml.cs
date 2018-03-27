using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.CollectionViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPageDemo : ContentPage
	{
		public ListViewPageDemo ()
		{
			InitializeComponent ();
		    listView.ItemsSource = new List<Color>
		    {
		        Color.Aqua, Color.Black, Color.Blue, Color.Fuchsia,
                Color.Gray, Color.Green, Color.Lime, Color.Maroon,
                Color.Navy, Color.Olive, Color.Pink, Color.Purple,
                Color.Red, Color.Silver, Color.Teal, Color.White, Color.Yellow
		    };
        }
	}
}
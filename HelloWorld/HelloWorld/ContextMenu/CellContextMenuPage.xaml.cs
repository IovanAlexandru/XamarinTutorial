using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.ContextMenu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CellContextMenuPage : ContentPage
	{
		public CellContextMenuPage ()
		{
			InitializeComponent ();
		    listView.ItemsSource = new ObservableCollection<string>()
		    {
                "Abc0",
                "Abc1",
		        "Abc2",
		        "Abc3",
		        "Abc4",
		        "Abc5",
		        "Abc6",
		        "Abc7",
		        "Abc8",
		        "Abc9"
            };
		}

	    private void AddMenuItem_OnClicked(object sender, EventArgs e)
	    {
	    }

	    private void UpdateMenuItem_OnClicked(object sender, EventArgs e)
	    {
	    }

	    private void DeleteMenuItem_OnClicked(object sender, EventArgs e)
	    {
	        var menuItem = sender as MenuItem;
	        string itemText = (menuItem.CommandParameter as Label)?.Text;
	        if (!string.IsNullOrEmpty(itemText))
	        {
	            (listView.ItemsSource as ObservableCollection<string>)?.Remove(itemText);
	        }
        }
    }
}
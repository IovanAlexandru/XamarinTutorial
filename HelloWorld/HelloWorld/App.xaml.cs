using HelloWorld.Bindings;
using HelloWorld.Bindings.CustomViews;
using HelloWorld.Bindings.ValueConverters;
using HelloWorld.Bitmaps;
using HelloWorld.CollectionViews;
using HelloWorld.ContextMenu;
using HelloWorld.ControlsDemo;
using HelloWorld.Grid;
using HelloWorld.MVVM;
using HelloWorld.MVVM.Commands;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
			MainPage = new CellContextMenuPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

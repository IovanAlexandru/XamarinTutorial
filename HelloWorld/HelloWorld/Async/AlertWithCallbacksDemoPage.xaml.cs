using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Async
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlertWithCallbacksDemoPage : ContentPage
	{
		public AlertWithCallbacksDemoPage ()
		{
			InitializeComponent ();
		}

	    private async void OnButtonClickedV2(object sender, EventArgs e)
	    {
	        Task<bool> task = DisplayAlert("Simple Alert",
	            "Decide on an option",
	            "yes or ok", "no or cancel");
	        label.Text = "Alert is currently displayed";
	        bool result = await task;
	        label.Text = String.Format("Alert {0} button was pressed", result ? "OK" : "Cancel");
        }


        private void OnButtonClicked(object sender, EventArgs e)
	    {
	        Task<bool> task = DisplayAlert("Simple Alert", 
                "Decide on an option", 
                "yes or ok", "no or cancel");
            task.ContinueWith(AlertDismissedCallback);
            label.Text = "Alert is currently displayed";
        }

	    private void AlertDismissedCallback(Task<bool> task)
	    {
	        Device.BeginInvokeOnMainThread(()=>
	        {
	            DisplayResultCallback(task.Result);
	        });
	    }

	    private void DisplayResultCallback(bool result)
	    {
	        label.Text = String.Format("Alert {0} button was pressed", result ? "OK" : "Cancel");
        }
	}
}
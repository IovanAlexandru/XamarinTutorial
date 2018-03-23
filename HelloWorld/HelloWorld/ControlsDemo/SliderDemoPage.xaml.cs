using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.ControlsDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SliderDemoPage : ContentPage
	{
		public SliderDemoPage ()
		{
			InitializeComponent ();
		}

	    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
	    {
	        label.Text = String.Format("Slider = {0}", e.NewValue);
        }
	}
}
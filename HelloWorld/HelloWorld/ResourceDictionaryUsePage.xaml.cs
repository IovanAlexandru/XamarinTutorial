using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResourceDictionaryUsePage : ContentPage
	{
        private const string CURRENT_DATE_TIME_RESOURCE_KEY = "currentDateTime";

        public ResourceDictionaryUsePage ()
		{
			InitializeComponent ();
		    Resources = new ResourceDictionary()
		    {
                { CURRENT_DATE_TIME_RESOURCE_KEY, "Not actually a date time" }
		    };

            Lbl.SetDynamicResource(Label.TextProperty, CURRENT_DATE_TIME_RESOURCE_KEY);

		    DateTime start = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Resources[CURRENT_DATE_TIME_RESOURCE_KEY] = DateTime.Now.ToString();
                return DateTime.Now - start < TimeSpan.FromSeconds(10);
            });
        }
	}
}
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonClickPage : ContentPage
    {
        public ButtonClickPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            LoggedEventsSL.Children.Add(new Label()
            {
                Text = $"Button clicked at: {DateTime.Now}"
            });

            ToogleSwitch.IsToggled = !ToogleSwitch.IsToggled;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
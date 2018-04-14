using Xamarin.Forms;

namespace HelloWorld.Navigation
{
    public class Page1Demo : ContentPage
    {
        public Page1Demo()
        {
            Title = nameof(Page1Demo);
            var stack = new StackLayout();
            var button = new Button()
            {
                Text = "Open Page 2"
            };
            button.Clicked += NavigateToPage2;
            stack.Children.Add(new Label()
            {
                Text = nameof(Page1Demo)
            });

            stack.Children.Add(button);

            Content = stack;
        }

        private async void NavigateToPage2(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Page2Demo());
        }
    }
}

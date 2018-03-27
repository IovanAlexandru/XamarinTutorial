using Xamarin.Forms;

namespace HelloWorld.CollectionViews
{
    public class TextCellListCodePage : ContentPage
    {
        public TextCellListCodePage()
        {
            DataTemplate dataTemplate = new DataTemplate(typeof(TextCell));
            dataTemplate.SetBinding(TextCell.TextProperty, nameof(NamedColor.FriendlyName));
            dataTemplate.SetBinding(TextCell.DetailProperty, new Binding(
                path: nameof(NamedColor.RgbDisplay), 
                stringFormat: "RGB = {0}"));
            Padding = new Thickness(10, Device.OnPlatform(20, 0 ,0), 10, 0);
            Content = new ListView()
            {
                ItemsSource = NamedColor.All,
                ItemTemplate = dataTemplate
            };
        }
    }
}

using Xamarin.Forms;

namespace HelloWorld.Bitmaps
{
    public class ResourceBitmapCodePage : ContentPage
    {
        public ResourceBitmapCodePage()
        {
            Content = new Image
            {
                Source = ImageSource.FromResource($"{nameof(HelloWorld)}.{nameof(Bitmaps)}.IMG_1415.JPG")
            };
        }
    }
}

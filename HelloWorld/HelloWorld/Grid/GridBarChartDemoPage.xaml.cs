using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Grid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridBarChartDemoPage : ContentPage
    {
        private const int COUNT = 100;
        private Random random = new Random();

        public GridBarChartDemoPage()
        {
            InitializeComponent();

            List<View> views = new List<View>();
            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += OnBoxViewTapped;

            for (int i = 0; i < COUNT; i++)
            {
                BoxView boxView = new BoxView()
                {
                    Color = Color.Accent,
                    HeightRequest = 300 * random.NextDouble(),
                    VerticalOptions = LayoutOptions.End,
                    StyleId = RandomNameGenerator()
                };

                boxView.GestureRecognizers.Add(tapGesture);
                views.Add(boxView);
            }

            grid.Children.AddHorizontal(views);
            Device.StartTimer(TimeSpan.FromMilliseconds(15), OnTimerTick);
        }

        private string RandomNameGenerator()
        {
            int numPieces = 1 + 2 * random.Next(1, 4);
            StringBuilder name = new StringBuilder();
            for (int i = 0; i < numPieces; i++)
            {
                name.Append(i % 2 == 0 ? _consonants[random.Next(_consonants.Length)] : _vowels[random.Next(_vowels.Length)]);
            }

            name[0] = Char.ToUpper(name[0]);

            return name.ToString();
        }

        // Arrays for Random Name Generator. 
        readonly string[] _vowels = { "a", "e", "i", "o", "u", "ai", "ei", "ie", "ou", "oo" };

        readonly string[] _consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };

        private bool OnTimerTick()
        {
            overlay.Opacity = Math.Max(0, overlay.Opacity - 0.0025);
            return true;
        }

        private void OnBoxViewTapped(object sender, EventArgs e)
        {
            BoxView boxView = (BoxView)sender;
            label.Text = $"The individual known as {boxView.StyleId} has a height of {boxView.HeightRequest} centimeters.";
            overlay.Opacity = 1;
        }
    }
}
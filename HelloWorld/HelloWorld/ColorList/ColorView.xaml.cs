using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.ColorList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorView : ContentView
    {
        private Color color;

        public ColorView()
        {
            InitializeComponent();
            // Alternative gesture binding.
            //TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            //this.GestureRecognizers.Add(tapGesture);
            //tapGesture.Tapped += TapGesture_Tapped;
        }

        private void TapGesture_Tapped(object sender, EventArgs e)
        {
            if (this.Tapped != null)
            {
                this.Tapped(this, e);
            }
        }

        private void DoubleTapGesture_Tapped(object sender, EventArgs e)
        {
            if (this.DoubleTapped != null)
            {
                this.DoubleTapped(this, e);
            }
        }

        [TypeConverter(typeof(ColorTypeConverter))]
        public Color Color
        {
            set
            {
                this.color = value;
                // Get the actual Color and set the other views. 
                boxView.Color = color;
                colorValueLabel.Text = String.Format("{0:X2}-{1:X2}-{2:X2}", (int) (255 * color.R),
                    (int) (255 * color.G), (int) (255 * color.B));
            }
            get => color;
        }

        public event EventHandler Tapped;
        public event EventHandler DoubleTapped;
    }
}

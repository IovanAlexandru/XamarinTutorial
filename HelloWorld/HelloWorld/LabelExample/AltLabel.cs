using Xamarin.Forms;

namespace HelloWorld.LabelExample
{
    public partial class AltLabel : Label
    {
        public static readonly BindableProperty PointSizeProperty = BindableProperty.Create(nameof(PointSize), typeof(double), typeof(AltLabel), 8.0, propertyChanging: OnPointSizeChanging, propertyChanged: OnPointSizeChanged);

        private static void OnPointSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            (bindable as AltLabel)?.OnPointSizeChanged((double) oldvalue, (double) newvalue);
        }

        private void OnPointSizeChanged(double oldValue, double newValue)
        {
            SetLabelFontSize(newValue);
        }


        private static void OnPointSizeChanging(BindableObject bindable, object oldvalue, object newvalue)
        {
            (bindable as AltLabel)?.OnPointSizeChanging((double) oldvalue, (double) newvalue);
        }

        private void OnPointSizeChanging(double oldValue, double newValue)
        {
            
        }

        public double PointSize
        {
            get { return (double)GetValue(PointSizeProperty); }
            set { SetValue(PointSizeProperty, value); }
        }

        private void SetLabelFontSize(double pointSize)
        {
            FontSize = 160 * pointSize / 72;
        }

        public AltLabel() : base()
        {           
        }
    }
}
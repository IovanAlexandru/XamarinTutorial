using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Bindings.CustomViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewCheckBox : ContentView
    {
        public event EventHandler<bool> CheckedChanged;

        public NewCheckBox()
        {
            InitializeComponent();
        }

        // Text property.
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(NewCheckBox));
        public string Text
        {
            set => SetValue(TextProperty, value);
            get => (string)GetValue(TextProperty);
        }

        // Text color.
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(NewCheckBox), Color.Default);
        public Color TextColor
        {
            set => SetValue(TextColorProperty, value);
            get => (Color)GetValue(TextColorProperty);
        }

        // FontSize property.
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(nameof(FontSize),
            typeof(double), typeof(NewCheckBox), Device.GetNamedSize(NamedSize.Default, typeof(Label)));
        [TypeConverter(typeof(FontSizeConverter))]
        public double FontSize
        {
            set => SetValue(FontSizeProperty, value);
            get => (double)GetValue(FontSizeProperty);
        }

        // FontAttributes property.
        public static readonly BindableProperty FontAttributesProperty = BindableProperty.Create(nameof(FontAttributes), typeof(FontAttributes), typeof(NewCheckBox), FontAttributes.None);
        public FontAttributes FontAttributes
        {
            set => SetValue(FontAttributesProperty, value);
            get => (FontAttributes)GetValue(FontAttributesProperty);
        }

        // IsChecked property. 
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(nameof(IsChecked), typeof(bool), typeof(NewCheckBox), false,
            propertyChanged: (BindableObject bindable, object oldValue, object newValue) =>
            {
                // Fire the event.
                NewCheckBox checkbox = (NewCheckBox)bindable;
                EventHandler<bool> eventHandler = checkbox.CheckedChanged;
                eventHandler?.Invoke(checkbox, (bool)newValue);
            });

        public bool IsChecked
        {
            set => SetValue(IsCheckedProperty, value);
            get => (bool)GetValue(IsCheckedProperty);
        }

        // Tap Gesture Recognizer handler.
        void OnCheckBoxTapped(object sender, EventArgs args)
        {
            IsChecked = !IsChecked;
        }
    }
}
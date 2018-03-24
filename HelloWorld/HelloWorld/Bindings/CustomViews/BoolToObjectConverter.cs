using System;
using System.Globalization;
using Xamarin.Forms;

namespace HelloWorld.Bindings.CustomViews
{
    public class BoolToObjectConverter<T> : IValueConverter
    {
        public T TrueObject { get; set; }
        public T FalseObject { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool convertedValue)
            {
                return convertedValue ? TrueObject : FalseObject;
            }

            return FalseObject;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return TrueObject.Equals(value);
        }
    }
}

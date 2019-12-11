using System;
using System.Globalization;
using Xamarin.Forms;


namespace MFractor.Samples.Converters
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class BoolNegationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool == false)
            {
                return default(bool);
            }

            var input = (bool)value;
            return !input;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool == false)
            {
                return default(bool);
            }

            var input = (bool)value;
            return !input;
        }
    }
}
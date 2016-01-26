using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Chip
{
    public class TruncateStringConverter: IMultiValueConverter, IValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Count() < 2)
            {
                throw new ArgumentException();
            }

            var text = (string) values.ElementAt(0);
            var maxLength = (int) values.ElementAt(1);
            return TruncateString(text, maxLength);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return TruncateString((string)value, 10);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public string TruncateString(string text, int length)
        {
            if (text.Length <= length)
            {
                return text;
            }
            return text.Substring(0, length - 3) + "...";
        }
    }
}

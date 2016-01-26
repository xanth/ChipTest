using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Chip
{
    public class TextToMaxLengthConverter: IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Count() < 2)
            {
                throw new ArgumentException();
            }

            var text = (string) values.ElementAt(0);
            var maxLength = (int) values.ElementAt(1);
            return LimitCharacters(text, maxLength);
        }

        public string LimitCharacters(string text, int maxLength)
        {
            if (text.Length <= maxLength)
            {
                return text;
            }

            return text.Substring(0, maxLength - 3) + "...";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

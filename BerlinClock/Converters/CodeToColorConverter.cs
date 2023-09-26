using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace BerlinClock.Converters
{
    public class CodeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var colorCode = (string)value;
            string colorName;
            var bc = new BrushConverter();
            if (colorCode == "R")
            {
                colorName = "Red";
            }
            else if (colorCode == "Y")
            {
                colorName = "Yellow";
            }
            else
            {
                colorName = "White";
            }
            return (Brush)bc.ConvertFrom(colorName);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

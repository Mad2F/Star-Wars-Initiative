using System;
using System.Collections.Generic;
using System.Text;

namespace Star_Wars
{
    class HeightConverter: System.Windows.Data.IValueConverter
    {
        public object Convert(object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            Console.WriteLine(targetType + " " + value + " " + parameter);
            return System.Convert.ToDouble(value) -
                   System.Convert.ToDouble(parameter);
        }

        public object ConvertBack(object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

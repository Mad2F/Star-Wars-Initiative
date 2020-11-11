using System;

namespace Star_Wars
{
    public class PercentageConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            Console.WriteLine(targetType + " " + value + " " + parameter);
            return System.Convert.ToDouble(value) *
                   System.Convert.ToDouble(parameter) / 100;
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

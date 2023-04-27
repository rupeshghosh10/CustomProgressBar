using System;
using System.Globalization;
using System.Windows.Data;

namespace CustomProgressbar.Converters;

internal class InverseProgressBarValueToWidthConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var progressBar = System.Convert.ToDouble(value);

        if (progressBar >= 100)
        {
            return "0*";
        }

        return $"{100.0 - progressBar}*";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

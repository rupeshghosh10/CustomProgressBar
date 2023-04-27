using System;
using System.Globalization;
using System.Windows.Data;

namespace CustomProgressbar.Converters;

internal class ProgressBarValueToWidthConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var progressBarValue = System.Convert.ToDouble(value);

        if (progressBarValue >= 100)
        {
            return "100*";
        }

        return $"{progressBarValue}*";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

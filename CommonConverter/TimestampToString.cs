using System;
using System.Globalization;
using System.Windows.Data;

namespace CommonConverter
{
  public class TimestampToString : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if(value is int i)
      {
        var tempTimeSpan = new TimeSpan(0, 0, i);

        return $"{tempTimeSpan.Hours:D2}:{tempTimeSpan.Minutes:D2}:{tempTimeSpan.Seconds:D2}";
      }

      throw new FormatException();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
  }
}

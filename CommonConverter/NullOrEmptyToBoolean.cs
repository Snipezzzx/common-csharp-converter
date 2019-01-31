using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace CommonConverter
{
  public class NullOrEmptyToBoolean : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      bool returnValue = false;

      switch (value)
      {
        case null:
          returnValue = false;
          break;
        case string s:
          returnValue = String.IsNullOrEmpty(s);
          break;
        case IEnumerable<object> list:
          returnValue = list.ToList().Count > 0;
          break;
        default:
          returnValue = false;
          break;
      }

      return returnValue;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
  }
}

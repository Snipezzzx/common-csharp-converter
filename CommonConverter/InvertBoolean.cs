﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace CommonConverter
{
  public class InvertBoolean : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if(value is bool b)
        return !b;

      throw new FormatException();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if(value is bool b)
        return !b;

      throw new FormatException();
    }
  }
}

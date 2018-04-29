using System;
using System.Globalization;
using System.Windows.Data;

namespace FotoSortierer_v2.Helper.Converter
{
    /// <inheritdoc />
    public class DataGridValueConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // return true if value >= 1
            return (value as int? ?? 0) >= 1;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // return true if value <= 1
            return (value as int? ?? 0) <= 1;
        }
    }
}
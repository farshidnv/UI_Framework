namespace Framework.UI.Resources.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;
    using System.Windows.Media;

    /// <summary>
    /// This class provides a mechanism for converting a boolean value into the appropriate text color for a button on
    /// the main application navigation bar.
    /// </summary>
    public class BoolToNavButtonTextColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? valueAsBool = value as bool?;

            if (valueAsBool == null)
            {
                // TODO: Log an error.
                return null;
            }

            return valueAsBool.Value
                ? new SolidColorBrush(Colors.Black)
                : new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // We don't need to convert back, this will be used for one-way bindings.
            return null;
        }
    }
}

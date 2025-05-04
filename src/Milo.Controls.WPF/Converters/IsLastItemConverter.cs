using System;
using System.Windows.Controls;
using System.Windows.Data;

namespace Milo.Controls.WPF.Converters
{
    internal class IsLastItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var contentPresenter = value as ContentPresenter;

            var itemsControl = ItemsControl.ItemsControlFromItemContainer(contentPresenter.TemplatedParent);
            var index = itemsControl.ItemContainerGenerator.IndexFromContainer(contentPresenter.TemplatedParent);
            return (index == (itemsControl.Items.Count - 1));
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}

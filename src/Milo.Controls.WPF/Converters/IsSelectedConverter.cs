using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using Milo.Core.Views;

namespace Milo.Controls.WPF.Converters
{
    internal sealed class IsSelectedConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is ContentPresenter contentPresenter)
            {
                var itemsControl = ItemsControl.ItemsControlFromItemContainer(contentPresenter.TemplatedParent);
                var tool = itemsControl?.ItemContainerGenerator.ItemFromContainer(contentPresenter.TemplatedParent) as IMiloViewMeta;
                if (itemsControl?.TemplatedParent is MiloWizardView wizardProgressBar)
                {
                    if (wizardProgressBar.SelectedTool == tool)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
           return new []
           {
               Binding.DoNothing
           };
        }
    }
}

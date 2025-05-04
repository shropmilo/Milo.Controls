using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Milo.Core.Views.Wizards;

namespace Milo.Controls.WPF.Converters
{
    internal sealed class IsProgressedConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((values[0] is ContentPresenter && values[1] is IMiloWizardViewMeta) == false)
            {
                return Visibility.Collapsed;
            }

            if (values[0] is ContentPresenter presenter)
            {
                var depObject = presenter.TemplatedParent;
                if (depObject != null)
                {
                    var itemsControl = ItemsControl.ItemsControlFromItemContainer(depObject);
                    if (itemsControl != null)
                    {
                        var tool = itemsControl.ItemContainerGenerator.ItemFromContainer(depObject) as IMiloWizardViewMeta;
                        if (itemsControl.TemplatedParent is MiloWizardView wizardProgressBar && wizardProgressBar.TrackProgress)
                        {
                            if (wizardProgressBar.IndexOfTool(tool) < wizardProgressBar.CurrentIndex())
                            {
                                return Visibility.Visible;
                            }
                        }
                    }
                }
            }
            return Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}

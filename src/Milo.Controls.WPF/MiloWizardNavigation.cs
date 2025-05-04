using System.Windows;
using System.Windows.Controls;

namespace Milo.Controls.WPF
{
    public class MiloWizardNavigation : ItemsControl
    {
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is MiloWizardItem;
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MiloWizardItem();
        }
    }
}
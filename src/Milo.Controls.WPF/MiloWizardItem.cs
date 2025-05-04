using System.Windows.Controls;
using System.Windows.Input;
using Milo.Core.Views.Wizards;

namespace Milo.Controls.WPF
{
    public class MiloWizardItem : ContentControl
    {
        protected override void OnMouseDoubleClick(MouseButtonEventArgs e)
        {
            if (ItemsControl.ItemsControlFromItemContainer(this) is ItemsControl itemsControl)
            {
                if (itemsControl.TemplatedParent is MiloWizardView wizard)
                {
                    wizard.SelectedTool = itemsControl.ItemContainerGenerator.ItemFromContainer(this) as IMiloWizardViewMeta;
                }
            }
            base.OnMouseDoubleClick(e);
        }
    }
}
using System.Windows;
using System.Windows.Controls;

namespace Milo.Controls.WPF
{
    /// <summary>
    ///
    /// </summary>
    public class MiloListView : ItemsControl
    {
        static MiloListView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MiloListView), new FrameworkPropertyMetadata(typeof(MiloListView)));
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is MiloListViewItem;
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MiloListViewItem();
        }
    }
}

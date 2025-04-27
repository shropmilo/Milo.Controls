using System.Windows;
using System.Windows.Controls;

namespace Milo.Controls.WPF
{
    /// <summary>
    ///
    /// </summary>
    public class MiloSpinner : ContentControl
    {
        static MiloSpinner()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MiloSpinner), new FrameworkPropertyMetadata(typeof(MiloSpinner)));
        }
    }
}

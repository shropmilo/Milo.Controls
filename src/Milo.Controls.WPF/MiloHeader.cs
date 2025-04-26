using System.Windows;
using System.Windows.Controls;

namespace Milo.Controls.WPF
{
    /// <summary>
    /// 
    /// </summary>
    public class MiloHeader : Control
    {
        static MiloHeader()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MiloHeader), new FrameworkPropertyMetadata(typeof(MiloHeader)));
        }
    }
}

using System.Windows;
using System.Windows.Controls;

namespace Milo.Controls.WPF
{
    /// <summary>
    /// 
    /// </summary>
    public class MiloSection : HeaderedContentControl
    {
        static MiloSection()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MiloSection), new FrameworkPropertyMetadata(typeof(MiloSection)));
        }
    }
}

using System.Windows;
using System.Windows.Controls;

namespace Milo.Controls.WPF
{
    public enum MiloHeaderType
    {
        Title,
        Subtitle,
        Caption
    }

    /// <summary>
    /// 
    /// </summary>
    public class MiloHeader : ContentControl
    {
        public static readonly DependencyProperty HeaderTypeProperty = DependencyProperty.Register(
            nameof(HeaderType), typeof(MiloHeaderType), typeof(MiloHeader), new PropertyMetadata(default(MiloHeaderType)));

        public MiloHeaderType HeaderType
        {
            get => (MiloHeaderType)GetValue(HeaderTypeProperty);
            set => SetValue(HeaderTypeProperty, value);
        }

        static MiloHeader()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MiloHeader), new FrameworkPropertyMetadata(typeof(MiloHeader)));
        }
    }
}

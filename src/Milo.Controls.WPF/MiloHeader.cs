using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(
            nameof(ImageSource), typeof(ImageSource), typeof(MiloHeader), new PropertyMetadata(default(ImageSource)));

        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

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

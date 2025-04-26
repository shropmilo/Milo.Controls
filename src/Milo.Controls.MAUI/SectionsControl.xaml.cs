using System.Collections.ObjectModel;

namespace Milo.Controls;

public partial class SectionsControl : ContentView
{
    public static readonly BindableProperty SectionsProperty = BindableProperty.Create(
        nameof(Sections), typeof(ObservableCollection<object>), typeof(SectionsControl));

    public ObservableCollection<object> Sections
    {
        get => (ObservableCollection<object>)GetValue(SectionsProperty);
        set => SetValue(SectionsProperty, value);
    }

	public SectionsControl()
	{
		InitializeComponent();
	}
}
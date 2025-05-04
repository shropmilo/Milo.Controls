using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Milo.Controls.WPF.Commands;
using Milo.Core.Views.Wizards;

namespace Milo.Controls.WPF
{
    /// <summary>
    ///View with top level navigation and content area
    /// </summary>
    public class MiloWizardView : Control
    {
        #region Dependency Properties

        public static readonly DependencyProperty TrackProgressProperty = DependencyProperty.Register(
            nameof(TrackProgress), typeof(bool), typeof(MiloWizardView), new PropertyMetadata(false));

        public static readonly DependencyProperty ToolProgressBrushProperty = DependencyProperty.Register(
            nameof(ToolProgressBrush), typeof(Brush), typeof(MiloWizardView), new PropertyMetadata(default(Brush)));

        public static readonly DependencyProperty SelectedToolBrushProperty = DependencyProperty.Register(
            nameof(SelectedToolBrush), typeof(Brush), typeof(MiloWizardView), new PropertyMetadata(default(Brush)));

        public static readonly DependencyProperty ToolsProperty = DependencyProperty.Register(
            nameof(Tools), typeof(IEnumerable<IMiloWizardViewMeta>), typeof(MiloWizardView), new PropertyMetadata(default(IEnumerable<IMiloWizardViewMeta>)));

        public static readonly DependencyProperty SelectedToolProperty = DependencyProperty.Register(
            nameof(SelectedTool), typeof(IMiloWizardViewMeta), typeof(MiloWizardView), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public IMiloWizardViewMeta SelectedTool
        {
            get => (IMiloWizardViewMeta)GetValue(SelectedToolProperty);
            set => SetValue(SelectedToolProperty, value);
        }

        public IEnumerable<IMiloWizardViewMeta> Tools
        {
            get => (IEnumerable<IMiloWizardViewMeta>)GetValue(ToolsProperty);
            set => SetValue(ToolsProperty, value);
        }

        public bool TrackProgress
        {
            get => (bool)GetValue(TrackProgressProperty);
            set => SetValue(TrackProgressProperty, value);
        }

        public Brush ToolProgressBrush
        {
            get => (Brush)GetValue(ToolProgressBrushProperty);
            set => SetValue(ToolProgressBrushProperty, value);
        }

        public Brush SelectedToolBrush
        {
            get => (Brush)GetValue(SelectedToolBrushProperty);
            set => SetValue(SelectedToolBrushProperty, value);
        }

        #endregion // Dependency Properties

        public ICommand NextCommand { get; }
        public ICommand BackCommand { get; }

        public MiloWizardView()
        {
            NextCommand = new DelegateCommand(OnNext, OnCanNext);
            BackCommand = new DelegateCommand(OnBack, OnCanBack);
        }

        static MiloWizardView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MiloWizardView), new FrameworkPropertyMetadata(typeof(MiloWizardView)));
        }

        private bool OnCanBack()
        {
            return CurrentIndex() > 0;
        }

        private void OnBack()
        {
            SelectedTool = Tools.ToList().ElementAt(CurrentIndex() - 1);
        }

        private bool OnCanNext()
        {
            return CurrentIndex() + 1 < TotalTools();
        }

        private void OnNext()
        {
            SelectedTool = Tools.ToList().ElementAt(CurrentIndex() + 1);
        }

        internal int IndexOfTool(IMiloWizardViewMeta tool)
        {
            if (SelectedTool == null)
                return 0;

            if (Tools == null)
                return 0;

            return Tools.ToList().IndexOf(tool);
        }

        internal int CurrentIndex()
        {
            return IndexOfTool(SelectedTool);
        }

        internal int TotalTools()
        {
            return Tools?.Count() ?? 0;
        }
    }
}

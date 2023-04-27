using System.Windows;
using System.Windows.Controls;

namespace CustomProgressbar
{
    /// <summary>
    /// Interaction logic for Progressbar.xaml
    /// </summary>
    public partial class Progressbar : UserControl
    {
        public Progressbar()
        {
            InitializeComponent();
            ProgressBarValue = 0;
        }

        public double ProgressBarValue
        {
            get => (double)GetValue(ProgressBarValueProperty);
            set => SetValue(ProgressBarValueProperty, value);
        }

        // Using a DependencyProperty as the backing store for ProgressBarValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressBarValueProperty =
            DependencyProperty.Register(nameof(ProgressBarValue), typeof(double), typeof(Progressbar));
    }
}

using System;
using System.Threading.Tasks;
using System.Windows;

namespace SampleProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(TimeSpan.FromSeconds(0.1));
                CustomProgressBar.ProgressBarValue = i;
            }
        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            CustomProgressBar.ProgressBarValue = 0;
        }
    }
}

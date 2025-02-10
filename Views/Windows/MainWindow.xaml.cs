using System.Windows;
using Tumbleweed.Views.Pages;

namespace Tumbleweed.Views.Windows
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is MainWindow mainWindow)
            {
                mainWindow.NavigationView.Navigate(typeof(HomePage));
            }
        }
    }
}

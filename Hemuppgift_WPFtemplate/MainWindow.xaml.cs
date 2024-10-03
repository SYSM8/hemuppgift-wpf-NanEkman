using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridButton(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Grid_Window());
        }

        private void StackPanelButton(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StackPanel_Window());
        }

        private void WrapPanelButton(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new WrapPanel_Window());
        }

        private void DockPanelButton(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DockPanel_Window());
        }
    }
}
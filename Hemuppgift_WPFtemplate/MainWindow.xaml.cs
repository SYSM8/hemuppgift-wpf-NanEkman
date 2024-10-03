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
            Grid_Window grid_Window = new Grid_Window();
            grid_Window.Show();
        }

        private void StackPanelButton(object sender, RoutedEventArgs e)
        {
            StackPanel_Window stackPanel_Window = new StackPanel_Window();
            stackPanel_Window.Show();
        }

        private void WrapPanelButton(object sender, RoutedEventArgs e)
        {
            WrapPanel_Window wrapPanel_Window = new WrapPanel_Window();
            wrapPanel_Window.Show();
        }

        private void DockPanelButton(object sender, RoutedEventArgs e)
        {
            DockPanel_Window dockPanel_Window = new DockPanel_Window();
            dockPanel_Window.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for WrapPanel_Window.xaml
    /// </summary>
    public partial class WrapPanel_Window : Window
    {
        public WrapPanel_Window()
        {
            InitializeComponent();
        }

        private void rbtn1_Click(object sender, RoutedEventArgs e)
        {
            if(rbtn1.IsChecked == true)
            {
                MyWrapPanel.Orientation = Orientation.Horizontal;
            }

        }

        private void rbtn2_Click(object sender, RoutedEventArgs e)
        {
            if (rbtn2.IsChecked == true)
            {
                // Sätt alla ellipser i vertikal layout
                MyWrapPanel.Orientation = Orientation.Vertical;
                // Lägger till en fast storlek för att ellipserna inte ska placeras bredvid varandra
                MyWrapPanel.Width = 110;
            }

        }
    }
}

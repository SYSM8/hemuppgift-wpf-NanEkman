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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for StackPanel_Window.xaml
    /// </summary>
    public partial class StackPanel_Window : Window
    {
        public StackPanel_Window()
        {
            InitializeComponent();
        }

        private void rbtn1_Click(object sender, RoutedEventArgs e)
        {
            if (rbtn1.IsChecked == true)
            {
                // Sätt alla rektanglar i horisontell layout
                SetHorizontalLayout();              
            }
        }

        private void rbtn2_Click(object sender, RoutedEventArgs e)
        {
            if(rbtn2.IsChecked == true)
            {
                // Sätt alla rektanglar i vertikal layout
                SetVerticalLayout();
            }
        }

        private void SetHorizontalLayout()
        {
            Canvas.SetLeft(rek1, 20);
            Canvas.SetTop(rek1, 50);

            Canvas.SetLeft(rek2, 130);
            Canvas.SetTop(rek2, 50);

            Canvas.SetLeft(rek3, 230);
            Canvas.SetTop(rek3, 50);

            Canvas.SetLeft(rek4, 320);
            Canvas.SetTop(rek4, 50);

            Canvas.SetLeft(rek5, 400);
            Canvas.SetTop(rek5, 50);

            Canvas.SetLeft(rek6, 470);
            Canvas.SetTop(rek6, 50);

            Canvas.SetLeft(rek7, 530);
            Canvas.SetTop(rek7, 50);

            Canvas.SetLeft(rek8, 580);
            Canvas.SetTop(rek8, 50);
        }

        private void SetVerticalLayout()
        {
            Canvas.SetLeft(rek1, 50);
            Canvas.SetTop(rek1, 20);

            Canvas.SetLeft(rek2, 50);
            Canvas.SetTop(rek2, 130);

            Canvas.SetLeft(rek3, 50);
            Canvas.SetTop(rek3, 230);

            Canvas.SetLeft(rek4, 50);
            Canvas.SetTop(rek4, 320);

            Canvas.SetLeft(rek5, 50);
            Canvas.SetTop(rek5, 400);

            Canvas.SetLeft(rek6, 50);
            Canvas.SetTop(rek6, 470);

            Canvas.SetLeft(rek7, 50);
            Canvas.SetTop(rek7, 530);

            Canvas.SetLeft(rek8, 50);
            Canvas.SetTop(rek8, 580);
        }
    }
}

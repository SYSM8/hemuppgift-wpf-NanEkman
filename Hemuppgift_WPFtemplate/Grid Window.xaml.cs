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
    /// Interaction logic for Grid_Window.xaml
    /// </summary>
    public partial class Grid_Window : Window
    {
        public Grid_Window()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            string row = txtRow.Text;
            string column = txtColumn.Text;

            int rowInput = Convert.ToInt32(row);
            int columnInput = Convert.ToInt32(column);

            // if i if samt kalla på ResetColumnBackground()? Loop? Foreach? 

            if (rowInput == 0 && columnInput == 0)
            {
                Column0.Text = $"Row 0, Column 0";
                Column0.Background = Brushes.LightGreen;
            }
            else if(rowInput == 0 && columnInput == 1)
            {
                Column1.Text = $"Row 0, Column 1";
                Column1.Background = Brushes.LightGreen;
            }
            else if (rowInput == 0 && columnInput == 2)
            {
                Column2.Text = $"Row 0, Column 2";
                Column2.Background = Brushes.LightGreen;
            }
            else if (rowInput == 0 && columnInput == 3)
            {
                Column3.Text = $"Row 0, Column 3";
                Column3.Background = Brushes.LightGreen;
            }            
        }
        // Metod för att reset bakgrunden
        public void ResetColumnBackground()
        {
            Column0.Background = Brushes.White;
            Column0.Text = "";
        }
    }
}

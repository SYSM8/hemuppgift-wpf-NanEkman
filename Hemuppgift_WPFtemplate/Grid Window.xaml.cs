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

            // Kontrollera att input är inom giltigt intervall
            if (rowInput >= 0 && rowInput <= 3 && columnInput >= 0 && columnInput <= 3)
            {
                // Återställ alla kolumner
                ResetColumnBackground();

                if (rowInput == 0 && columnInput == 0)
                {
                    Column0.Text = $"Row {rowInput}, Column {columnInput}";
                    Column0.Background = Brushes.LightGreen;
                }
                else if (rowInput == 0 && columnInput == 1)
                {
                    Column1.Text = $"Row {rowInput}, Column {columnInput}";
                    Column1.Background = Brushes.LightGreen;
                }
                else if (rowInput == 0 && columnInput == 2)
                {
                    Column2.Text = $"Row {rowInput}, Column {columnInput}"; ;
                    Column2.Background = Brushes.LightGreen;
                }
                else if (rowInput == 0 && columnInput == 3)
                {
                    Column3.Text = $"Row {rowInput}, Column {columnInput}"; ;
                    Column3.Background = Brushes.LightGreen;
                }
                else if (rowInput == 1 && columnInput == 0)
                {
                    Column4.Text = $"Row {rowInput}, Column {columnInput}"; ;
                    Column4.Background = Brushes.LightGreen;
                }
                else if (rowInput == 1 && columnInput == 1)
                {
                    Column5.Text = $"Row {rowInput}, Column {columnInput}"; ;
                    Column5.Background = Brushes.LightGreen;
                }
                else if (rowInput == 1 && columnInput == 2)
                {
                    Column6.Text = $"Row {rowInput}, Column {columnInput}"; ;
                    Column6.Background = Brushes.LightGreen;
                }
                else if (rowInput == 1 && columnInput == 3)
                {
                    Column7.Text = $"Row {rowInput}, Column {columnInput}"; ;
                    Column7.Background = Brushes.LightGreen;
                }
                else if (rowInput == 2 && columnInput == 0)
                {
                    Column8.Text = $"Row {rowInput}, Column {columnInput}"; ;
                    Column8.Background = Brushes.LightGreen;
                }
                else if (rowInput == 2 && columnInput == 1)
                {
                    Column9.Text = $"Row {rowInput}, Column {columnInput}"; ;
                    Column9.Background = Brushes.LightGreen;
                }
                else if (rowInput == 2 && columnInput == 2)
                {
                    Column10.Text = $"Row {rowInput}, Column {columnInput}"; ;
                    Column10.Background = Brushes.LightGreen;
                }

            }
            else
            {
                MessageBox.Show("Vänligen mata in ett heltal mellan 0-15");
            }          
        }
        // Metod för att reset bakgrunden
        public void ResetColumnBackground()
        {
            Column0.Background = Brushes.White;
            Column0.Text = "";

            Column1.Background = Brushes.White;
            Column1.Text = "";

            Column2.Background = Brushes.White;
            Column2.Text = "";

            Column3.Background = Brushes.White;
            Column3.Text = "";

            Column4.Background = Brushes.White;
            Column4.Text = "";

            Column5.Background = Brushes.White;
            Column5.Text = "";

            Column6.Background = Brushes.White;
            Column6.Text = "";

            Column7.Background = Brushes.White;
            Column7.Text = "";

            // Fortsätta med resterande upp till Column15
        }
    }
}

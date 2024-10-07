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
            // Kontrollera om inmatningen är giltig
            if (int.TryParse(txtRow.Text, out int rowInput) && int.TryParse(txtColumn.Text, out int columnInput) &&
                rowInput >= 0 && rowInput < 4 && columnInput >= 0 && columnInput < 4)
            {
                // Anropa metod för att återställa kolumner när nya värden skrivs in av användaren
                ResetColumnBackground();

                // Bestäm vilket TextBlock som ska uppdateras baserat på rad och kolumn
                TextBlock selectedTextBlock = GetTextBlock(rowInput, columnInput);

                // Uppdatera valt textbloxk
                //if(selectedTextBlock.isNullorEmpty)
                if(selectedTextBlock  != null) 
                {
                    selectedTextBlock.Text = $"Row {rowInput}, Column {columnInput}";
                    selectedTextBlock.Background = Brushes.LightGreen;
                }
            }
            else
            {
                MessageBox.Show("Vänligen mata in ett heltal mellan 0 och 3 för både rad och kolumn");
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

            Column8.Background = Brushes.White;
            Column8.Text = "";

            Column9.Background = Brushes.White;
            Column9.Text = "";

            Column10.Background = Brushes.White;
            Column10.Text = "";

            Column11.Background = Brushes.White;
            Column11.Text = "";

            Column12.Background = Brushes.White;
            Column12.Text = "";

            Column13.Background = Brushes.White;
            Column13.Text = "";

            Column14.Background = Brushes.White;
            Column14.Text = "";

            Column15.Background = Brushes.White;
            Column15.Text = "";
        }

        // Metod för att hämta rätt TextBlock beroende på rad och kolumn
        private TextBlock GetTextBlock(int row, int column)
        {
            if (row == 0 && column == 0) return Column0;
            if (row == 0 && column == 1) return Column1;
            if (row == 0 && column == 2) return Column2;
            if (row == 0 && column == 3) return Column3;
            if (row == 1 && column == 0) return Column4;
            if (row == 1 && column == 1) return Column5;
            if (row == 1 && column == 2) return Column6;
            if (row == 1 && column == 3) return Column7;
            if (row == 2 && column == 0) return Column8;
            if (row == 2 && column == 1) return Column9;
            if (row == 2 && column == 2) return Column10;
            if (row == 2 && column == 3) return Column11;
            if (row == 3 && column == 0) return Column12;
            if (row == 3 && column == 1) return Column13;
            if (row == 3 && column == 2) return Column14;
            if (row == 3 && column == 3) return Column15;

            // Returnera ett tomt TextBlock om ingen matchning hittas
            return new TextBlock();           
        }
    }
}


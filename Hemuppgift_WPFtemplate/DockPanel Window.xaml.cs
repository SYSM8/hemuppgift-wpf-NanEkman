﻿using System;
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
    /// Interaction logic for DockPanel_Window.xaml
    /// </summary>
    public partial class DockPanel_Window : Window
    {
        public DockPanel_Window()
        {
            InitializeComponent();
        }


        private void btnCenter_Click(object sender, RoutedEventArgs e)
        {
            if(btnCenter.IsEnabled)
            {
                ImageTrophy.IsEnabled = true;
            }
        }
    }
}

﻿using Okurleiga_hf.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Okurleiga_hf.Windows
{
    /// <summary>
    /// Interaction logic for ViewCustomerWindow.xaml
    /// </summary>
    public partial class ChangeCustomerWindow : Window
    {
        public ChangeCustomerWindow()
        {
            InitializeComponent();
        }
             

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Notað til að loada töflunni uppúr gagnagrunninum.
            CollectionViewSource view = new CollectionViewSource();
            SharedContext.dBContext.Customers.Load();
            SharedContext.Customers = SharedContext.dBContext.Customers.Local;

            view.Source = SharedContext.Customers;
            this.DataContext = view;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

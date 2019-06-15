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
using Okurleiga_hf.Context;
using Okurleiga_hf.Models;

namespace Okurleiga_hf.Windows
{
    /// <summary>
    /// Interaction logic for NewCustomerWindow.xaml
    /// </summary>
    public partial class NewCustomerWindow : Window
    {
        Customer c;

        public NewCustomerWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            c = new Customer();
            this.DataContext = c;
        }

        private void BtnSaveClick_Click(object sender, RoutedEventArgs e)
        {
            SharedContext.dBContext.Customers.Add(c);
            SharedContext.dBContext.SaveChanges();
            this.Close();
        }

        private void BtnQuitClick_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

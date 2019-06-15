using Okurleiga_hf.Context;
using Okurleiga_hf.Models;
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

namespace Okurleiga_hf.Windows
{
    /// <summary>
    /// Interaction logic for NewApartmentOwnerWindow.xaml
    /// </summary>
    public partial class NewApartmentOwnerWindow : Window
    {
        ApartmentOwner ao;

        public NewApartmentOwnerWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ao = new ApartmentOwner();
            this.DataContext = ao;
            
        }
        private void BtnSaveClick_Click(object sender, RoutedEventArgs e)
        {            
            SharedContext.dBContext.ApartmentOwners.Add(ao);
            SharedContext.dBContext.SaveChanges();
            this.Close();
        }

    }
}

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
    /// Interaction logic for NewApartmentIncidentWindow.xaml
    /// </summary>
    public partial class NewApartmentIncidentWindow : Window
    {
        public NewApartmentIncidentWindow()
        {
            InitializeComponent();
        }

        private void btn_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Save(object sender, RoutedEventArgs e)
        {

        }
    }
}

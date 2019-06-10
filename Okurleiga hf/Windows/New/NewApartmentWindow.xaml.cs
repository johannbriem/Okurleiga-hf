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
    /// Interaction logic for NewApartmentWindow.xaml
    /// </summary>
    public partial class NewApartmentWindow : Window
    {
        public NewApartmentWindow()
        {
            InitializeComponent();
        }

        private void btn_QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_SaveClick(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

using Okurleiga_hf.Context;
using Okurleiga_hf.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Okurleiga_hf.Windows.New
{
    /// <summary>
    /// Interaction logic for NewEmployeeWindow.xaml
    /// </summary>
    public partial class NewEmployeeWindow : Window
    {
        Employee emp;

        public NewEmployeeWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            emp = new Employee();
            this.DataContext = emp;
        }

        private void BtnSaveClick_Click(object sender, RoutedEventArgs e)
        {            
            SharedContext.dBContext.Employees.Add(emp);
            SharedContext.dBContext.SaveChanges();
            this.Close();
        }

        private void BtnQuitClick_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

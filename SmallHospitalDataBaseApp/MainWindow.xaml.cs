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
using System.Data.Entity;
using System.Collections;

namespace SmallHospitalDataBaseApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void employees_button(object sender, RoutedEventArgs e)
        {
            newEmployee newEmployee = new newEmployee();
            newEmployee.Show();
        }

        private void patients_button(object sender, RoutedEventArgs e)
        {
            newPatient newPatient = new newPatient();
            newPatient.Show();
        }

        private void contacts_button(object sender, RoutedEventArgs e)
        {
            newContact newContact = new newContact();
            newContact.Show();
        }

        private void addresses_button(object sender, RoutedEventArgs e)
        {
            newAddress newAddress = new newAddress();
            newAddress.Show();
        }

        private void exit_button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

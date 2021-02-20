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

namespace SmallHospitalDataBaseApp
{
    /// <summary>
    /// Interaction logic for Doctors.xaml
    /// </summary>
    public partial class Doctors : Window
    {
        public Doctors()
        {
            InitializeComponent();
            DoctorsService doctor = new DoctorsService();

            this.doctorDataGrid.ItemsSource = doctor.GetList();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int index = 0; index < 5; index++)
            {
                doctorDataGrid.Columns[index].Visibility = Visibility.Visible;
            }
            doctorDataGrid.Columns[0].Header = "Doctor ID";
            doctorDataGrid.Columns[1].Header = "Name";
            doctorDataGrid.Columns[2].Header = "Surname";
            doctorDataGrid.Columns[3].Header = "Employment Date";
            doctorDataGrid.Columns[4].Header = "Release Date";

            //for (int indexI = 0; indexI > 5; indexI++)
            //{
            //    doctorDataGrid.Columns[indexI].Visibility = Visibility.Collapsed;

            //}
            //doctorDataGrid.Columns[6].Visibility = Visibility.Collapsed;
            //doctorDataGrid.Columns[7].Visibility = Visibility.Collapsed;
            //doctorDataGrid.Columns[8].Visibility = Visibility.Collapsed;
        }

        private void update_employee_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void refresh_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void delete_employee_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void cancel_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void doctorDataGrid_Selection(object sender, SelectionChangedEventArgs e)
        {
            //something
        }
    }
}

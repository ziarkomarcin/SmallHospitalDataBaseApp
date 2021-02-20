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
    /// Interaction logic for newPatient.xaml
    /// </summary>
    public partial class Patients : Window
    {
        public Patients()
        {
            InitializeComponent();
            PatientService patient = new PatientService();

            this.patientDataGrid.ItemsSource = patient.GetList();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //for (int index = 0; index < 5; index++)
            //{
            //    patientDataGrid.Columns[index].Visibility = Visibility.Visible;
            //}
            patientDataGrid.Columns[0].Header = "Patient ID";
            patientDataGrid.Columns[1].Header = "Name";
            patientDataGrid.Columns[2].Header = "Surname";
            patientDataGrid.Columns[3].Header = "Admission Date";
            patientDataGrid.Columns[4].Header = "Discharge Date";

            //for (int indexI = 0; indexI > 5; indexI++)
            //{
            //    patientDataGrid.Columns[indexI].Visibility = Visibility.Collapsed;

            //}
        }


        private void update_patient_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void refresh_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void delete_patient_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void cancel_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void patientDataGrid_Selection(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

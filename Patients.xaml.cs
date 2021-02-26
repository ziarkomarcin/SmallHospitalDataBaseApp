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
        PatientService PatientService = new PatientService();

        public Patients()
        {
            InitializeComponent();
            PatientService patient = new PatientService();

            this.patientDataGrid.ItemsSource = patient.GetList();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            patientDataGrid.Columns[0].Header = "Patient ID";
            patientDataGrid.Columns[1].Header = "Name";
            patientDataGrid.Columns[2].Header = "Surname";
            patientDataGrid.Columns[3].Header = "Admission Date";
            patientDataGrid.Columns[4].Header = "Discharge Date";


            patientDataGrid.Columns[5].Visibility = Visibility.Collapsed;
        }

        private void add_patient_button(object sender, RoutedEventArgs e)
        {
                string admission = patient_AdmissionTextBox.Text;
                DateTime.TryParseExact(admission, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime adm);

                if (patient_NameTextBox.Text != "" && patient_SurnameTextBox.Text != "" && admission != "")
                {

                PatientService.AddPatient(patient_NameTextBox.Text,
                                            patient_SurnameTextBox.Text,
                                            adm);
                Refresh();
            }
                else MessageBox.Show("...Name, Surname & Admission Date must be entered...");
            
        }

        private int patientID = 0;
        private void delete_patient_button(object sender, RoutedEventArgs e)
        {
            try
            {
                var patient = PatientService.SelectPatientID(patientID);
                PatientService.RemovePatient(patient);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Cannot remove that patient.");
            }
            Refresh();
        }

        private void cancel_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void patientDataGrid_Selection(object sender, SelectionChangedEventArgs e)
        {
            patients p = this.patientDataGrid.SelectedItem as patients;
            if (p is null)
            {
                this.patient_NameTextBox2.Text = string.Empty.ToString();
                this.patient_SurnameTextBox2.Text = string.Empty.ToString();
                this.patient_AdmissionTextBox2.Text = string.Empty;
                return;
            }
            var txt = this.patientID = p.patient_id;
            this.patient_IDTextBox.Text = txt.ToString();
            this.patient_NameTextBox2.Text = p.firstname.ToString();
            this.patient_SurnameTextBox2.Text = p.lastname.ToString();
            this.patient_AdmissionTextBox2.Text = p.date_of_admission.ToString();
            this.patient_DischargeTextBox.Text = p.date_of_discharge.ToString();
        }

        private void edit_patient_button(object sender, RoutedEventArgs e)
        {
            if (patient_NameTextBox2.Text != "" && patient_SurnameTextBox2.Text != "" && patient_AdmissionTextBox2.Text != "")
            {
                string date = patient_AdmissionTextBox2.Text;
                DateTime.TryParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime newDate);

                string date2 = patient_DischargeTextBox.Text;
                DateTime.TryParseExact(date2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime newDate2);


                var patient = PatientService.SelectPatientID(patientID);

                string name = patient_NameTextBox2.Text.ToString().Trim();
                
                string pat = patient_SurnameTextBox2.Text.ToString().Trim();

                    PatientService.EditPatient(patient, name, pat, newDate, newDate2);
                    Refresh();
                
            }
            else MessageBox.Show("All fields must be filled");
        }

        private void Refresh()
        {
            Patients newWindow = new Patients();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            this.Close();
        }

    }
}

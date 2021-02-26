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

        DoctorsService DoctorsService = new DoctorsService();

        public Doctors()
        {
            InitializeComponent();
            DoctorsService doctor = new DoctorsService();

            this.doctorDataGrid.ItemsSource = doctor.GetList();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //for (int index = 0; index < 5; index++)
            //{
            //    doctorDataGrid.Columns[index].Visibility = Visibility.Visible;
            //}
            doctorDataGrid.Columns[0].Header = "Doctor ID";
            doctorDataGrid.Columns[1].Header = "Name";
            doctorDataGrid.Columns[2].Header = "Surname";
            doctorDataGrid.Columns[3].Header = "Employment Date";
            doctorDataGrid.Columns[4].Header = "Release Date";

            //doctorDataGrid.Columns[4].Visibility = Visibility.Collapsed;
            doctorDataGrid.Columns[5].Visibility = Visibility.Collapsed;
        }

        private void cancel_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private int doctorID = 0;
        private void doctorDataGrid_SEL(object sender, SelectionChangedEventArgs e)
        {
            doctors d = this.doctorDataGrid.SelectedItem as doctors;
            if (d is null)
            {
                this.doctor_EditNameTextBox.Text = string.Empty.ToString();
                this.doctor_EditSurnameTextBox.Text = string.Empty.ToString();
                this.doctor_EditEmploymentTextBox.Text = string.Empty;
                this.doctor_ReleaseTextBox.Text = string.Empty;
                return;
            }
            this.doctor_EditNameTextBox.Text = d.firstname.ToString();
            this.doctor_EditSurnameTextBox.Text = d.lastname.ToString();
            this.doctor_EditEmploymentTextBox.Text = d.date_of_employment.ToString();
            this.doctor_ReleaseTextBox.Text = d.date_of_release.ToString();
            var txt = this.doctorID = d.doctor_id;
            this.doctor_idTextBox.Text = txt.ToString();
        }
        private void add_doctor_button(object sender, RoutedEventArgs e)
        {
            string employmentInput = doctor_EmploymentTextBox.Text;
            DateTime.TryParseExact(employmentInput, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime a);

            if (doctor_NameTextBox.Text != "" && doctor_SurnameTextBox.Text != "" && employmentInput != "")
            {
                DoctorsService.AddDoctor(doctor_NameTextBox.Text,
                                         doctor_SurnameTextBox.Text,
                                         a);
                Refresh();
            }
            else MessageBox.Show("...Name, Surname & Employment Date must be entered...");

        }

        private void Refresh()
        {
            Doctors newWindow = new Doctors();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            this.Close();
        }

        private void edit_button(object sender, RoutedEventArgs e)
        {
            if (doctor_EditNameTextBox.Text != "" && doctor_EditSurnameTextBox.Text != "" && doctor_EditEmploymentTextBox.Text != "")
            {
                string date = doctor_EditEmploymentTextBox.Text;
                DateTime.TryParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime newDate);

                string date2 = doctor_ReleaseTextBox.Text;
                DateTime.TryParseExact(date2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime newDate2);


                var doctor = DoctorsService.SelectDoctorID(doctorID);

                string name = doctor_EditNameTextBox.Text.ToString().Trim();

                string pat = doctor_EditSurnameTextBox.Text.ToString().Trim();

                DoctorsService.EditDoctor(doctor, name, pat, newDate, newDate2);
                Refresh();

            }
            else MessageBox.Show("All fields must be filled");
        }
    }
}

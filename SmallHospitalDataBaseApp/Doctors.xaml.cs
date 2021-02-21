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

            doctorDataGrid.Columns[4].Visibility = Visibility.Collapsed;
            doctorDataGrid.Columns[5].Visibility = Visibility.Collapsed;
        }

        private void refresh_button(object sender, RoutedEventArgs e)
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

        private void add_doctor_button(object sender, RoutedEventArgs e)
        {
            string employmentInput = doctor_EmploymentTextBox.Text;
            DateTime.TryParseExact(employmentInput, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime a);
           

            //string releaseInput = doctor_EmploymentTextBox.Text;
            //DateTime.TryParseExact(releaseInput, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime b);
           

            if (doctor_NameTextBox.Text != "" && doctor_SurnameTextBox.Text != "" && employmentInput != "")
            {

                //DateTime employDate;
                //bool employResult = DateTime.TryParse(doctor_EmploymentTextBox.Text, out employDate);
                //if (!employResult)
                //{
                //    MessageBox.Show("Date is written with numbers (YYYY-MM-DD)");
                //    return;
                //}
                //DateTime relDate;
                //bool relResult = DateTime.TryParse(doctor_ReleaseTextBox.Text, out relDate);
                //if (!relResult)
                //{
                //    MessageBox.Show("Date is written with numbers (YYYY-MM-DD)");
                //    return;
                //}

                DoctorsService.AddDoctor(doctor_NameTextBox.Text,
                                         doctor_SurnameTextBox.Text,
                                         a
                                         /*b*/);

                //ReloadList();
            }
            else MessageBox.Show("...Name, Surname & Employment Date must be entered...");
        }

        private void delete_doctor_button(object sender, RoutedEventArgs e)
        {
        }
    }
}

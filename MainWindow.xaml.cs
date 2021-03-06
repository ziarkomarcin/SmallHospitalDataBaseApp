﻿using System;
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
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void doctors_button(object sender, RoutedEventArgs e)
        {
            Doctors Doctors = new Doctors();
            Doctors.Show();
        }

        private void patients_button(object sender, RoutedEventArgs e)
        {
            Patients Patients = new Patients();
            Patients.Show();
        }

        private void diagnosis_button(object sender, RoutedEventArgs e)
        {
            Diagnosis Diagnosis = new Diagnosis();
            Diagnosis.Show();
        }

        private void visits_button(object sender, RoutedEventArgs e)
        {
            Visits Visits = new Visits();
            Visits.Show();
        }

        private void exit_button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void info_button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($@"INFORMATION FOR APP USERS!
Doctors who are currently dismissed may admit patients for private visits," +
                            " as some offices are rented by them." +
                            $@"

The removal of doctors is not possible due to the above-mentioned information.");
        }
    }
}

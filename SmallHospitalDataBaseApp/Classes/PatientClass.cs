using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallHospitalDataBaseApp
{
    class PatientClass
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime dateA { get; set; }
        public DateTime dateD { get; set; }

        public PatientClass(patients patient)
        {
            id = patient.patient_id;
            firstname = patient.firstname;
            lastname = patient.lastname;
            dateA = (DateTime)patient.date_of_admission;
            dateD = (DateTime)patient.date_of_discharge;
        }
    }

    
    class PatientService
    {
        MyHospitalDBEntities context = new MyHospitalDBEntities();

        /// <summary>
        /// List of Patients
        /// </summary>
        /// <returns>List of Patients in DB</returns>
        public List<patients> GetList()
        {
            return context.patients.ToList();
        }

        /// <summary>
        /// Adding new Patient in DB
        /// </summary>
        /// <param name="patients_name">Patient's firstname</param>
        /// <param name="patients_lastname">Patient's lastname </param>
        /// <param name="patients_admission_date">Date of Patient's admission</param>
        ///// <param name="patients_release_date">Date of Patient's release</param>
        public void AddPatient(string patients_name, string patients_lastname, DateTime patients_admission_date/*, DateTime patients_release_date*/)
        {
            patients Patient = new patients()
            {
                firstname = patients_name,
                lastname = patients_lastname,
                date_of_admission = patients_admission_date,
                //date_of_release = patients_release_date,
            };
            context.patients.Add(Patient);
            context.SaveChanges();
        }

        public void RemovePatient(patients patient)
        {
            if (patient != null) context.patients.Remove(patient);
            context.SaveChanges();

        }

        public patients SelectPatientID(int patientID)
        {
            var x = context.patients.FirstOrDefault(y => y.patient_id == patientID);
            return x;
        }

        public void EditPatient(patients patient, string patient_name, string patient_surname, DateTime patient_dateA, DateTime patient_dateD)
        {
            if (patient != null)
            {
                patient.firstname = patient_name;
                patient.lastname = patient_surname;
                patient.date_of_admission = patient_dateA;
                patient.date_of_discharge = patient_dateD;
            }
            context.SaveChanges();
        }
    }
}

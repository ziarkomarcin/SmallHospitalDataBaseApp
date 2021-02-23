using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallHospitalDataBaseApp
{
    class PatientClass
    {
        //smth
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallHospitalDataBaseApp
{


    public class DoctorsClass
    {
        public int id { get; set; }
        public string doctors_name { get; set; }
        public string doctors_surname { get; set; }
        public DateTime employment { get; set; }
        public DateTime release { get; set; }

       public DoctorsClass(doctors doctor)
        {
            id = doctor.doctor_id;
            doctors_name = doctor.firstname;
            doctors_surname = doctor.lastname;
            employment = doctor.date_of_employment;
            release = (DateTime)doctor.date_of_release;
        }
    }

    public class DoctorsService
    {
        MyHospitalDBEntities context = new MyHospitalDBEntities();

        /// <summary>
        /// List of Doctors
        /// </summary>
        /// <returns>List of Doctors in DB</returns>
        public List<doctors> GetList()
        {
            return context.doctors.ToList();
        }

        /// <summary>
        /// Adding new Doctor in DB
        /// </summary>
        /// <param name="doctors_name">Doctor's firstname</param>
        /// <param name="doctors_lastname">Doctor's lastname </param>
        /// <param name="doctors_employment_date">Date of Doctor's employment</param>
        ///// <param name="doctors_release_date">Date of Doctor's release</param>
        public void AddDoctor(string doctors_name, string doctors_lastname, DateTime doctors_employment_date/*, DateTime doctors_release_date*/)
        {
            doctors Doctor = new doctors()
            {
                firstname = doctors_name,
                lastname = doctors_lastname,
                date_of_employment = doctors_employment_date,
                //date_of_release = doctors_release_date,
            };
            context.doctors.Add(Doctor);
            context.SaveChanges();
        }

        /// <param name="doctors_release_date">Date of Doctor's release</param>
        public void EditDoctor(doctors doctor, string doctor_name, string doctor_surname, DateTime employment, DateTime release)
        {
            if (doctor != null)
            {
                doctor.firstname = doctor_name;
                doctor.lastname = doctor_surname;
                doctor.date_of_employment = employment;
                doctor.date_of_release = release;
            }
            context.SaveChanges();
        }

        public void RemoveDoctor(doctors doctor)
        {
            if (doctor != null) context.doctors.Remove(doctor);
            context.SaveChanges();
        }

        public doctors SelectDoctorID(int doctorID)
        {
            var x = context.doctors.FirstOrDefault(y => y.doctor_id == doctorID);
            return x;
        }

    }
}

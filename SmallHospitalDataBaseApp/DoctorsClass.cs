using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallHospitalDataBaseApp
{
    class DoctorsClass
    {

    }

    class DoctorsService
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
        
    }
}

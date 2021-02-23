using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallHospitalDataBaseApp
{
    class VisitClass
    {
    }

    class VisitService
    {
        MyHospitalDBEntities context = new MyHospitalDBEntities();

        public List<visits> GetList()
        {
            return context.visits.ToList();
        }

        /// <summary>
        /// Adding new Diagnosis in DB
        /// </summary>
        /// <param name="visit_doctor_id">Connect doctor with Visit</param>
        /// <param name="visit_patient_id">Connect patient with Visit</param>
        /// <param name="visit_date">Date of Visit</param>\
        public void AddVisit(int visit_doctor_id, int visit_patient_id, DateTime visit_date)
        {
            visits Visit = new visits()
            {
                doctor_id = visit_doctor_id,
                patient_id = visit_patient_id,
                date_of_visit = visit_date,
            };
            context.visits.Add(Visit);
            context.SaveChanges();
        }
    }

}

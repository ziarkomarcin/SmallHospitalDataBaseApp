using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallHospitalDataBaseApp
{
    public class VisitClass
    {
        public int id { get; set; }
        public int doctorID { get; set; }
        public int patientID { get; set; }
        public DateTime date { get; set; }

        public VisitClass(visits visit)
        {
            id = visit.visit_id;
            doctorID = visit.doctor_id;
            patientID = visit.patient_id;
            date = (DateTime)visit.date_of_visit;
        }
    }

    public class VisitService
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

        /// <summary>
        /// Remove visit from DB
        /// </summary>
        /// <param name="removeVisit">remove visit - ID</param>
        public void RemoveVisit(visits visit)
        {
            if (visit != null) context.visits.Remove(visit);
            context.SaveChanges();

        }

        /// <summary>
        /// Returns product record selected by ID 
        /// </summary>
        /// <param name="visitID">Visit ID</param>
        /// <returns>Returns visit record selected by ID </returns>
        public visits SelectVisitID(int visitID)
        {
            var x = context.visits.FirstOrDefault(y => y.visit_id == visitID);
            return x;
        }

        public void EditVisit(visits visit, int visit_doctor_id, int visit_patient_id, DateTime visit_date)
        {
            if (visit != null)
            {
                visit.doctor_id = visit_doctor_id;
                visit.patient_id = visit_patient_id;
                visit.date_of_visit = visit_date;
            }
            context.SaveChanges();
        }

    }

}

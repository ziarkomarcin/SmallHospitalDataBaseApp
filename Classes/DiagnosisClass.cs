using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallHospitalDataBaseApp
{
    class DiagnosisClass
    {

        public int id { get; set; }
        public int vis { get; set; }
        public string illness { get; set; }
        public string desc { get; set; }

        public DiagnosisClass(diagnosis diagnose)
        {
            id = diagnose.diagnosis_id;
            vis = diagnose.visit_id;
            illness = diagnose.illness_name;
            desc = diagnose.description;
        }
    }
    class DiagnosisService
    {
        MyHospitalDBEntities context = new MyHospitalDBEntities();

        /// <summary>
        /// List of Diagnosis
        /// </summary>
        /// <returns>List of Patients in DB</returns>
        public List<diagnosis> GetList()
        {
            return context.diagnosis.ToList();
        }

        /// <summary>
        /// Adding new Diagnosis in DB
        /// </summary>
        /// <param name="diagnosis_visit_id">Connect diagnosis with Visit</param>
        /// <param name="diagnosis_illness_name">Patient's illness name</param>
        /// <param name="diagnosis_description">Description of diagno & illness</param>\
        public void AddDiagnosis(int diagnosis_visit_id, string diagnosis_illness_name, string diagnosis_description)
        {
            diagnosis Diagnosis = new diagnosis()
            {
                visit_id = diagnosis_visit_id,
                illness_name = diagnosis_illness_name,
                description = diagnosis_description,
            };
            context.diagnosis.Add(Diagnosis);
            context.SaveChanges();
        }

        public void RemoveDiagnose(diagnosis diagnose)
        {
            if (diagnose != null) context.diagnosis.Remove(diagnose);
            context.SaveChanges();

        }


        public diagnosis SelectDiagID(int diagnosisID)
        {
            var x = context.diagnosis.FirstOrDefault(y => y.diagnosis_id == diagnosisID);
            return x;
        }

        public void EditDiagnosis(diagnosis diagnose, int diagnosis_visit_id, string diagnosis_illness_name, string diagnosis_description)
        {
            if (diagnose != null)
            {
                diagnose.visit_id = diagnosis_visit_id;
                diagnose.illness_name = diagnosis_illness_name;
                diagnose.description = diagnosis_description;
            }
            context.SaveChanges();
        }
    }
}
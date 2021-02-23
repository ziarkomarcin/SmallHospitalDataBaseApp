using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallHospitalDataBaseApp
{
    class DiagnosisClass
    {
        //smth
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

        public void EditDiagnosis(int diagnosis_id, int diagnosis_visit_id, string diagnosis_illness_name, string diagnosis_description)
        {
             
        }
    }
}
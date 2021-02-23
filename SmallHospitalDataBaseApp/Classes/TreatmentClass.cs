using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallHospitalDataBaseApp
{
    class TreatmentClass
    {
        //smth
    }
    class TreatmentService
    {
        MyHospitalDBEntities context = new MyHospitalDBEntities();

        public List<treatments> GetList()
        {
            return context.treatments.ToList();
        }

    }
}
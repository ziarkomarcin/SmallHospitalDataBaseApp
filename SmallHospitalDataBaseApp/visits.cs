//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmallHospitalDataBaseApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class visits
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public visits()
        {
            this.diagnosis = new HashSet<diagnosis>();
        }
    
        public int visit_id { get; set; }
        public int doctor_id { get; set; }
        public int patient_id { get; set; }
        public System.DateTime date_of_visit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diagnosis> diagnosis { get; set; }
        public virtual doctors doctors { get; set; }
        public virtual patients patients { get; set; }
    }
}

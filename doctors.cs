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
    
    public partial class doctors
    {
        public doctors()
        {
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doctors(List<doctors> doc)
        {
            this.visits = new HashSet<visits>();
        }
    
        public int doctor_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public System.DateTime date_of_employment { get; set; }
        public Nullable<System.DateTime> date_of_release { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<visits> visits { get; set; }
    }
}
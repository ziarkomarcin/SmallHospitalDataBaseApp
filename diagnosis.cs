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
    
    public partial class diagnosis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public diagnosis()
        {
            this.treatments = new HashSet<treatments>();
        }
    
        public int diagnosis_id { get; set; }
        public int visit_id { get; set; }
        public string illness_name { get; set; }
        public string description { get; set; }
    
        public virtual visits visits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<treatments> treatments { get; set; }
    }
}
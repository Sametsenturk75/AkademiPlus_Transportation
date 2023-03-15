//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AkademiPlus_Transportation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Transportation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Transportation()
        {
            this.TBL_Process = new HashSet<TBL_Process>();
        }
    
        public int TransportationID { get; set; }
        public Nullable<int> Customer { get; set; }
        public Nullable<int> Category { get; set; }
        public Nullable<int> Product { get; set; }
        public Nullable<int> Employee { get; set; }
        public string Status { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Description { get; set; }
    
        public virtual TBL_Category TBL_Category { get; set; }
        public virtual TBL_Customer TBL_Customer { get; set; }
        public virtual TBL_Employee TBL_Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Process> TBL_Process { get; set; }
        public virtual TBL_Product TBL_Product { get; set; }
    }
}

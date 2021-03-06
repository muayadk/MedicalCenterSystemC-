//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalCenterManangement.DataModeView
{
    using System;
    using System.Collections.Generic;
    
    public partial class patientsTab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public patientsTab()
        {
            this.appointmentTab = new HashSet<appointmentTab>();
            this.visitTab = new HashSet<visitTab>();
        }
    
        public decimal paId { get; set; }
        public string paCode { get; set; }
        public string paFname { get; set; }
        public string paLname { get; set; }
        public string paSex { get; set; }
        public string paBrithday { get; set; }
        public Nullable<int> paAge { get; set; }
        public Nullable<int> paMobile1 { get; set; }
        public Nullable<int> paMobile2 { get; set; }
        public byte[] paImg { get; set; }
        public string paAddress { get; set; }
        public string paCountry { get; set; }
        public string paCity { get; set; }
        public string paBloodType { get; set; }
        public string paState { get; set; }
        public string paType { get; set; }
        public Nullable<decimal> ACC_Num { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appointmentTab> appointmentTab { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<visitTab> visitTab { get; set; }
    }
}

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
    
    public partial class clinicTab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clinicTab()
        {
            this.doctorsTab = new HashSet<doctorsTab>();
        }
    
        public decimal clId { get; set; }
        public string clCode { get; set; }
        public string clName { get; set; }
        public Nullable<int> clMobile { get; set; }
        public string clAddress { get; set; }
        public string clNote { get; set; }
        public Nullable<decimal> hoId { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual hospitalCenterTab hospitalCenterTab { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doctorsTab> doctorsTab { get; set; }
    }
}

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
    
    public partial class activeMaterialTab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public activeMaterialTab()
        {
            this.dragTab = new HashSet<dragTab>();
        }
    
        public decimal acId { get; set; }
        public string acCode { get; set; }
        public string acName { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dragTab> dragTab { get; set; }
    }
}
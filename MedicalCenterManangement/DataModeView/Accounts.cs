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
    
    public partial class Accounts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accounts()
        {
            this.Cash = new HashSet<Cash>();
        }
    
        public int Acc_Num { get; set; }
        public string Acc_Name { get; set; }
        public string Acc_Type { get; set; }
        public int Parent_Acc { get; set; }
        public int Degree { get; set; }
        public string Report { get; set; }
        public string Coin { get; set; }
        public string Acc_Nature { get; set; }
        public Nullable<int> Coin_Num { get; set; }
        public string Acc_Stat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cash> Cash { get; set; }
    }
}

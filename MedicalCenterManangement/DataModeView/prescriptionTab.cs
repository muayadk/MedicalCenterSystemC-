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
    
    public partial class prescriptionTab
    {
        public decimal presId { get; set; }
        public string presCode { get; set; }
        public string presName { get; set; }
        public string presQyt { get; set; }
        public string presTimeUse { get; set; }
        public string presSize { get; set; }
        public string presPriod { get; set; }
        public Nullable<decimal> reId { get; set; }
        public Nullable<decimal> drId { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual dragTab dragTab { get; set; }
        public virtual recipeTab recipeTab { get; set; }
    }
}

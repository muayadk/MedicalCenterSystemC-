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
    
    public partial class previewTab
    {
        public decimal prId { get; set; }
        public string prCode { get; set; }
        public string prName { get; set; }
        public string prDate { get; set; }
        public string prTime { get; set; }
        public string prNote { get; set; }
        public Nullable<decimal> viId { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual visitTab visitTab { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DrzavaValuta
    {
    
        public string IDDrzava { get; set; }
        public string IDValuta { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
    
        public virtual Drzava Drzava { get; set; }
        public virtual Valuta Valuta { get; set; }
    }
}

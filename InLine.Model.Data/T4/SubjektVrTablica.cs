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
    
    public partial class SubjektVrTablica
    {
    
        public int IDSubjektVr { get; set; }
        public int IDSubjektTablica { get; set; }
        public Nullable<bool> Odabir { get; set; }
    
        public virtual SubjektTablica SubjektTablica { get; set; }
        public virtual SubjektVr SubjektVr { get; set; }
    }
}

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
    
    public partial class OsobaPrebivaliste
    {
    
        public long ID
    	{
    		get { return this.ID_OsobaPrebivaliste; }
    		set { this.ID_OsobaPrebivaliste = value; }
    	}
        public long ID_OsobaPrebivaliste { get; set; }
        public long ID_Osoba { get; set; }
        public long ID_Opcina { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
    
        public virtual Opcina Opcina { get; set; }
        public virtual Osoba Osoba { get; set; }
    }
}

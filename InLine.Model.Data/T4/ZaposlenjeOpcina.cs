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
    
    public partial class ZaposlenjeOpcina
    {
    
        public long ID
    	{
    		get { return this.ID_ZaposlenjeOpcina; }
    		set { this.ID_ZaposlenjeOpcina = value; }
    	}
        public long ID_ZaposlenjeOpcina { get; set; }
        public long ID_Zaposlenje { get; set; }
        public long ID_Opcina { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
    
        public virtual Zaposlenje Zaposlenje { get; set; }
        public virtual Opcina Opcina { get; set; }
    }
}

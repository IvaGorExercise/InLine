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
    
    public partial class OpcinaZupanija
    {
    
        public long ID
    	{
    		get { return this.ID_OpcinaZupanija; }
    		set { this.ID_OpcinaZupanija = value; }
    	}
        public long ID_OpcinaZupanija { get; set; }
        public long ID_Opcina { get; set; }
        public DateTime DatOd { get; set; }
        public DateTime DatDo { get; set; }
        public bool AktivU { get; set; }
        public long ID_Zupanija { get; set; }
        public long? ID_OpcinaTip { get; set; }
        public string Opis { get; set; }
        public byte[] GrbSlika { get; set; }
        public string PathGrb { get; set; }
        public string SjedOpcina { get; set; }
        public long? ID_MjestoPosta { get; set; }
        public string NazivOpcina { get; set; }
        public string TIP { get; set; }
    
        public virtual MjestoPosta MjestoPosta { get; set; }
        public virtual Opcina Opcina { get; set; }
        public virtual OpcinaTip OpcinaTip { get; set; }
        public virtual Zupanija Zupanija { get; set; }
    }
}

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
    
    public partial class Ulica
    {
    
        public long ID
    	{
    		get { return this.ID_Ulica; }
    		set { this.ID_Ulica = value; }
    	}
        public long ID_Ulica { get; set; }
        public long? ID_Mjesto { get; set; }
        public long? ID_MjestoPosta { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
        public string NazivStari { get; set; }
        public bool Aktivno { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public Nullable<bool> AdresaBezUlice { get; set; }
        public long? ID_UlicaTip { get; set; }
        public string PathSlika { get; set; }
        public string PathPlan { get; set; }
        public string PathSlika2 { get; set; }
        public long? ID_Zupanija { get; set; }
        public long? ID_Opcina { get; set; }
        public long? ID_MjestoOpcina { get; set; }
    
        public virtual Mjesto Mjesto { get; set; }
        public virtual MjestoOpcina MjestoOpcina { get; set; }
        public virtual MjestoPosta MjestoPosta { get; set; }
        public virtual Opcina Opcina { get; set; }
        public virtual UlicaTip UlicaTip { get; set; }
        public virtual Zupanija Zupanija { get; set; }
    }
}

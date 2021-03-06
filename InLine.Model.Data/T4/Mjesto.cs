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
    
    public partial class Mjesto
    {
    
        public Mjesto()
        {
    
            this.Lokacija = new HashSet<Lokacija>();
            this.MjestoDrzava = new HashSet<MjestoDrzava>();
            this.MjestoGrMjesto = new HashSet<MjestoGrMjesto>();
            this.MjestoOpcina = new HashSet<MjestoOpcina>();
            this.MjestoOpcina1 = new HashSet<MjestoOpcina>();
            this.MjestoPosta = new HashSet<MjestoPosta>();
            this.Ulica = new HashSet<Ulica>();
        }
    
        public long ID
    	{
    		get { return this.ID_Mjesto; }
    		set { this.ID_Mjesto = value; }
    	}
        public long ID_Mjesto { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string NazivAlt { get; set; }
        public string NazivHPT { get; set; }
        public bool StaroMjesto { get; set; }
        public bool NeOK { get; set; }
        public bool NePosta { get; set; }
        public string Opis { get; set; }
        public string StsMjesto { get; set; }
        public bool IzborMjesto { get; set; }
        public string MBr { get; set; }
        public string PathSlika { get; set; }
        public string PathPlan { get; set; }
        public string PathSlika2 { get; set; }
        public long? ID_MjestoTip { get; set; }
        public long? ID_Opcina { get; set; }
        public string IDDrzava { get; set; }
        public string Opcina { get; set; }
        public string Zupanija { get; set; }
    
        public virtual ICollection<Lokacija> Lokacija { get; set; }
        public virtual Drzava Drzava { get; set; }
        public virtual MjestoTip MjestoTip { get; set; }
        public virtual Opcina Opcina1 { get; set; }
        public virtual ICollection<MjestoDrzava> MjestoDrzava { get; set; }
        public virtual ICollection<MjestoGrMjesto> MjestoGrMjesto { get; set; }
        public virtual ICollection<MjestoOpcina> MjestoOpcina { get; set; }
        public virtual ICollection<MjestoOpcina> MjestoOpcina1 { get; set; }
        public virtual ICollection<MjestoPosta> MjestoPosta { get; set; }
        public virtual ICollection<Ulica> Ulica { get; set; }
    }
}

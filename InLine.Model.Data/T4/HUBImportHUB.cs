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
    
    public partial class HUBImportHUB
    {
    
        public long ID
    	{
    		get { return this.ID_HUBImportHUB; }
    		set { this.ID_HUBImportHUB = value; }
    	}
        public long ID_HUBImportHUB { get; set; }
        public long ID_HUBImport { get; set; }
        public long ID_HUB { get; set; }
        public int BrojUgovor { get; set; }
        public int BrojObrok { get; set; }
        public int? BrojAneks { get; set; }
        public long? ID_UgovorStanOtkupObrok { get; set; }
        public DateTime? DatumDospijece { get; set; }
        public int? BrojObrokZadnji { get; set; }
        public long? ID_Kupac { get; set; }
        public string NazivKupac { get; set; }
        public string AdresaKupac { get; set; }
        public string MjestoKupac { get; set; }
        public long? ID_Stan { get; set; }
        public long? ID_Zgrada { get; set; }
        public Nullable<decimal> IznosObrok { get; set; }
        public Nullable<decimal> IznosUplata { get; set; }
        public Nullable<decimal> Iznos { get; set; }
        public Nullable<decimal> IznosObrokPrije { get; set; }
        public Nullable<decimal> IznosUplataPrije { get; set; }
        public Nullable<decimal> IznosDug { get; set; }
        public Nullable<decimal> IznosObracun { get; set; }
        public Nullable<decimal> IznosRevalorizacija { get; set; }
        public Nullable<decimal> IznosZateznaKamata { get; set; }
        public int? AneksBrojObrokOd { get; set; }
        public int? AneksBrojObrok { get; set; }
        public int? UgovorBrojObrok { get; set; }
    
        public virtual HUB HUB { get; set; }
        public virtual HUBImport HUBImport { get; set; }
    }
}

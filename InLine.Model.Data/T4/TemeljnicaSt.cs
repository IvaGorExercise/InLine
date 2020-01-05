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
    
    public partial class TemeljnicaSt
    {
    
        public TemeljnicaSt()
        {
    
            this.TemeljnicaStKriterij = new HashSet<TemeljnicaStKriterij>();
        }
    
        public long ID
    	{
    		get { return this.ID_TemeljnicaSt; }
    		set { this.ID_TemeljnicaSt = value; }
    	}
        public long ID_TemeljnicaSt { get; set; }
        public long ID_Temeljnica { get; set; }
        public int RedniBroj { get; set; }
        public DateTime Datum { get; set; }
        public DateTime? DatumDospijeca { get; set; }
        public long ID_KontniPlanSt { get; set; }
        public long? ID_Subjekt { get; set; }
        public long? ID_Objekt { get; set; }
        public long? ID_Zapis { get; set; }
        public long? ID_Davanje { get; set; }
        public decimal IznosDuguje { get; set; }
        public decimal IznosPotrazuje { get; set; }
        public string IDValuta { get; set; }
        public decimal IznosDugujeValuta { get; set; }
        public decimal IznosPotrazujeValuta { get; set; }
        public decimal Tecaj { get; set; }
        public long? ID_Tecaj { get; set; }
        public string Opis { get; set; }
        public string ZapisOpis { get; set; }
        public long? ID_KontniPlanAnalitika { get; set; }
    
        public virtual Davanje Davanje { get; set; }
        public virtual KontniPlanAnalitika KontniPlanAnalitika { get; set; }
        public virtual KontniPlanSt KontniPlanSt { get; set; }
        public virtual Temeljnica Temeljnica { get; set; }
        public virtual Objekt Objekt { get; set; }
        public virtual Subjekt Subjekt { get; set; }
        public virtual Tecaj Tecaj1 { get; set; }
        public virtual Valuta Valuta { get; set; }
        public virtual Zapis Zapis { get; set; }
        public virtual ICollection<TemeljnicaStKriterij> TemeljnicaStKriterij { get; set; }
    }
}

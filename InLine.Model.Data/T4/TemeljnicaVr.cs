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
    
    public partial class TemeljnicaVr
    {
    
        public TemeljnicaVr()
        {
    
            this.KontniPlanTemeljnicaVr = new HashSet<KontniPlanTemeljnicaVr>();
            this.Temeljnica = new HashSet<Temeljnica>();
        }
    
        public long ID
    	{
    		get { return this.ID_TemeljnicaVr; }
    		set { this.ID_TemeljnicaVr = value; }
    	}
        public long ID_TemeljnicaVr { get; set; }
        public long ID_GlavnaKnjiga { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string IDValuta { get; set; }
        public decimal Tecaj { get; set; }
        public string Opis { get; set; }
    
        public virtual GlavnaKnjiga GlavnaKnjiga { get; set; }
        public virtual ICollection<KontniPlanTemeljnicaVr> KontniPlanTemeljnicaVr { get; set; }
        public virtual ICollection<Temeljnica> Temeljnica { get; set; }
        public virtual Valuta Valuta { get; set; }
    }
}
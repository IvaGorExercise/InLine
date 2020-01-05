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
    
    public partial class KnjigaIRA
    {
    
        public KnjigaIRA()
        {
    
            this.KnjigaIRAPDV = new HashSet<KnjigaIRAPDV>();
        }
    
        public long ID
    	{
    		get { return this.ID_KnjigaIRA; }
    		set { this.ID_KnjigaIRA = value; }
    	}
        public long ID_KnjigaIRA { get; set; }
        public long? ID_Zapis { get; set; }
        public long ID_PoslovnaGodina { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public long ID_RacunIzlaz { get; set; }
        public decimal IznosProlaznaSt { get; set; }
        public decimal IznosNeoporezivo { get; set; }
        public decimal IznosIzvoz { get; set; }
        public decimal IznosMedunarodniPrijevoz { get; set; }
        public decimal IznosTuzemstvo { get; set; }
        public decimal IznosOstalo { get; set; }
    
        public virtual RacunIzlaz RacunIzlaz { get; set; }
        public virtual PoslovnaGodina PoslovnaGodina { get; set; }
        public virtual Zapis Zapis { get; set; }
        public virtual ICollection<KnjigaIRAPDV> KnjigaIRAPDV { get; set; }
    }
}
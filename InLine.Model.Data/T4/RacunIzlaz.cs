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
    
    public partial class RacunIzlaz
    {
    
        public RacunIzlaz()
        {
    
            this.KnjigaIRA = new HashSet<KnjigaIRA>();
            this.RacunIzlazKontniPlan = new HashSet<RacunIzlazKontniPlan>();
            this.RacunIzlazSt = new HashSet<RacunIzlazSt>();
        }
    
        public long ID
    	{
    		get { return this.ID_RacunIzlaz; }
    		set { this.ID_RacunIzlaz = value; }
    	}
        public long ID_RacunIzlaz { get; set; }
        public long? ID_Zapis { get; set; }
        public long ID_PoslovniSubjekt { get; set; }
        public long ID_Subjekt { get; set; }
    
        public virtual ICollection<KnjigaIRA> KnjigaIRA { get; set; }
        public virtual PoslovniSubjekt PoslovniSubjekt { get; set; }
        public virtual Subjekt Subjekt { get; set; }
        public virtual Zapis Zapis { get; set; }
        public virtual ICollection<RacunIzlazKontniPlan> RacunIzlazKontniPlan { get; set; }
        public virtual ICollection<RacunIzlazSt> RacunIzlazSt { get; set; }
    }
}
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
    
    public partial class LokacijaLokacijaStruktura
    {
    
        public LokacijaLokacijaStruktura()
        {
    
            this.LokacijaLokacija = new HashSet<LokacijaLokacija>();
        }
    
        public long ID
    	{
    		get { return this.ID_LokacijaLokacijaStruktura; }
    		set { this.ID_LokacijaLokacijaStruktura = value; }
    	}
        public long ID_LokacijaLokacijaStruktura { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<LokacijaLokacija> LokacijaLokacija { get; set; }
    }
}

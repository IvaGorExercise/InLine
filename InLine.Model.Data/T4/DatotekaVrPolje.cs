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
    
    public partial class DatotekaVrPolje
    {
    
        public DatotekaVrPolje()
        {
    
            this.DatotekaPolje = new HashSet<DatotekaPolje>();
        }
    
        public long ID
    	{
    		get { return this.ID_DatotekaVrPolje; }
    		set { this.ID_DatotekaVrPolje = value; }
    	}
        public long ID_DatotekaVrPolje { get; set; }
        public long ID_DatotekaVrVerzija { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public long ID_DatotekaVrPoljeTip { get; set; }
        public int? Duljina { get; set; }
        public int? Pozicija { get; set; }
    
        public virtual ICollection<DatotekaPolje> DatotekaPolje { get; set; }
        public virtual DatotekaVrPoljeTip DatotekaVrPoljeTip { get; set; }
        public virtual DatotekaVrVerzija DatotekaVrVerzija { get; set; }
    }
}
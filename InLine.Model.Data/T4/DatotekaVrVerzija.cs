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
    
    public partial class DatotekaVrVerzija
    {
    
        public DatotekaVrVerzija()
        {
    
            this.DatotekaVrPolje = new HashSet<DatotekaVrPolje>();
        }
    
        public long ID
    	{
    		get { return this.ID_DatotekaVrVerzija; }
    		set { this.ID_DatotekaVrVerzija = value; }
    	}
        public long ID_DatotekaVrVerzija { get; set; }
        public long ID_DatotekaVr { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
    
        public virtual DatotekaVr DatotekaVr { get; set; }
        public virtual ICollection<DatotekaVrPolje> DatotekaVrPolje { get; set; }
    }
}
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
    
    public partial class Datoteka
    {
    
        public Datoteka()
        {
    
            this.DatotekaPolje = new HashSet<DatotekaPolje>();
        }
    
        public long ID
    	{
    		get { return this.ID_Datoteka; }
    		set { this.ID_Datoteka = value; }
    	}
        public long ID_Datoteka { get; set; }
        public long ID_Zapis { get; set; }
        public long? ID_ZapisIzvor { get; set; }
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime Datum { get; set; }
    
        public virtual Zapis Zapis { get; set; }
        public virtual Zapis Zapis1 { get; set; }
        public virtual ICollection<DatotekaPolje> DatotekaPolje { get; set; }
    }
}

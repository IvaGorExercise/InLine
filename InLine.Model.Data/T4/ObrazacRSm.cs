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
    
    public partial class ObrazacRSm
    {
    
        public ObrazacRSm()
        {
    
            this.ObrazacRSmA2005A = new HashSet<ObrazacRSmA2005A>();
            this.ObrazacRSmB2005A = new HashSet<ObrazacRSmB2005A>();
        }
    
        public long ID
    	{
    		get { return this.ID_ObrazacRSm; }
    		set { this.ID_ObrazacRSm = value; }
    	}
        public long ID_ObrazacRSm { get; set; }
        public long ID_Zapis { get; set; }
        public long ID_Dohodak { get; set; }
        public int IDObrazacRSmVerzija { get; set; }
        public string DatotekaNaziv { get; set; }
        public string Datoteka { get; set; }
    
        public virtual Dohodak Dohodak { get; set; }
        public virtual ObrazacRSmVerzija ObrazacRSmVerzija { get; set; }
        public virtual Zapis Zapis { get; set; }
        public virtual ICollection<ObrazacRSmA2005A> ObrazacRSmA2005A { get; set; }
        public virtual ICollection<ObrazacRSmB2005A> ObrazacRSmB2005A { get; set; }
    }
}

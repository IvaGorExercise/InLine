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
    
    public partial class ZapisGr
    {
    
        public ZapisGr()
        {
    
            this.ZapisGrZapis = new HashSet<ZapisGrZapis>();
            this.ZapisGrZapisGr = new HashSet<ZapisGrZapisGr>();
            this.ZapisGrZapisGr1 = new HashSet<ZapisGrZapisGr>();
        }
    
        public long ID
    	{
    		get { return this.ID_ZapisGr; }
    		set { this.ID_ZapisGr = value; }
    	}
        public long ID_ZapisGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<ZapisGrZapis> ZapisGrZapis { get; set; }
        public virtual ICollection<ZapisGrZapisGr> ZapisGrZapisGr { get; set; }
        public virtual ICollection<ZapisGrZapisGr> ZapisGrZapisGr1 { get; set; }
    }
}
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
    
    public partial class ZupanijaGrZupanija
    {
    
        public ZupanijaGrZupanija()
        {
    
            this.ZupanijaGrZupanijaDatum = new HashSet<ZupanijaGrZupanijaDatum>();
        }
    
        public long ID
    	{
    		get { return this.ID_ZupanijaGrZupanija; }
    		set { this.ID_ZupanijaGrZupanija = value; }
    	}
        public long ID_ZupanijaGrZupanija { get; set; }
        public long ID_ZupanijaGr { get; set; }
        public long ID_Zupanija { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
    
        public virtual Zupanija Zupanija { get; set; }
        public virtual ZupanijaGr ZupanijaGr { get; set; }
        public virtual ICollection<ZupanijaGrZupanijaDatum> ZupanijaGrZupanijaDatum { get; set; }
    }
}

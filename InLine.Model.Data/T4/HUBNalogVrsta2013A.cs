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
    
    public partial class HUBNalogVrsta2013A
    {
    
        public HUBNalogVrsta2013A()
        {
    
            this.HUB2013A = new HashSet<HUB2013A>();
            this.ZbrojniNalog2013A = new HashSet<ZbrojniNalog2013A>();
        }
    
        public int IDHUBNalogVrsta2013A { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
        public bool Koristi { get; set; }
    
        public virtual ICollection<HUB2013A> HUB2013A { get; set; }
        public virtual ICollection<ZbrojniNalog2013A> ZbrojniNalog2013A { get; set; }
    }
}

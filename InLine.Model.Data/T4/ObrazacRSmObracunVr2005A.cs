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
    
    public partial class ObrazacRSmObracunVr2005A
    {
    
        public ObrazacRSmObracunVr2005A()
        {
    
            this.Dohodak = new HashSet<Dohodak>();
            this.ObrazacRSmDopusteno2005A = new HashSet<ObrazacRSmDopusteno2005A>();
        }
    
        public int IDObrazacRSmObracunVr2005A { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<Dohodak> Dohodak { get; set; }
        public virtual ICollection<ObrazacRSmDopusteno2005A> ObrazacRSmDopusteno2005A { get; set; }
    }
}

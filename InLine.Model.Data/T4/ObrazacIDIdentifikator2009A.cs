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
    
    public partial class ObrazacIDIdentifikator2009A
    {
    
        public ObrazacIDIdentifikator2009A()
        {
    
            this.ObrazacID2009A = new HashSet<ObrazacID2009A>();
            this.ObrazacID2011A = new HashSet<ObrazacID2011A>();
        }
    
        public int IDObrazacIDIdentifikator2009A { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<ObrazacID2009A> ObrazacID2009A { get; set; }
        public virtual ICollection<ObrazacID2011A> ObrazacID2011A { get; set; }
    }
}

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
    
    public partial class ObrazacIPIdentifikator2005A
    {
    
        public ObrazacIPIdentifikator2005A()
        {
    
            this.ObrazacIP2011A = new HashSet<ObrazacIP2011A>();
        }
    
        public int IDObrazacIPIdentifikator2005A { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
    
        public virtual ICollection<ObrazacIP2011A> ObrazacIP2011A { get; set; }
    }
}

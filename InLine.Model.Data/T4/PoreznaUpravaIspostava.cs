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
    
    public partial class PoreznaUpravaIspostava
    {
    
        public long ID
    	{
    		get { return this.ID_PoreznaUpravaIspostava; }
    		set { this.ID_PoreznaUpravaIspostava = value; }
    	}
        public long ID_PoreznaUpravaIspostava { get; set; }
        public long ID_PoreznaUprava { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Sifra { get; set; }
    
        public virtual PoreznaUprava PoreznaUprava { get; set; }
    }
}

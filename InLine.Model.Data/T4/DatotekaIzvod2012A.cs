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
    
    public partial class DatotekaIzvod2012A
    {
    
        public long ID
    	{
    		get { return this.ID_DatotekaIzvod2012A; }
    		set { this.ID_DatotekaIzvod2012A = value; }
    	}
        public long ID_DatotekaIzvod2012A { get; set; }
        public long ID_DatotekaIzvod { get; set; }
        public string VBDI { get; set; }
        public string Naziv { get; set; }
        public string OIB { get; set; }
        public int Vrsta { get; set; }
        public DateTime Datum { get; set; }
    
        public virtual DatotekaIzvod DatotekaIzvod { get; set; }
    }
}

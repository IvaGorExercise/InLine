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
    
    public partial class KnjigaIRAPDV
    {
    
        public long ID
    	{
    		get { return this.ID_KnjigaIRAPDV; }
    		set { this.ID_KnjigaIRAPDV = value; }
    	}
        public long ID_KnjigaIRAPDV { get; set; }
        public long ID_KnjigaIRA { get; set; }
        public long ID_PDV { get; set; }
        public decimal IznosOsnova { get; set; }
        public decimal Iznos { get; set; }
    
        public virtual PDV PDV { get; set; }
        public virtual KnjigaIRA KnjigaIRA { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class KorisnikGrSPParam
    {
        public long ID
    	{
    		get { return this.ID_KorisnikGrSPParam; }
    		set { this.ID_KorisnikGrSPParam = value; }
    	}
        public long ID_KorisnikGrSPParam { get; set; }
        public long ID_KorisnikGrSP { get; set; }
        public string Param { get; set; }
        public bool? ValueBit { get; set; }
        public string ValueString { get; set; }
        public int? ValueInt { get; set; }
        public decimal? Value { get; set; }
        public DateTime? ValueDate { get; set; }
        public TimeSpan? ValueTime { get; set; }
        public DateTime? ValueDateTime { get; set; }
        public decimal? ValueDecimal { get; set; }
    
        public virtual KorisnikGrSP KorisnikGrSP { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class KorisnikFilterParametarItem : Model.Admin.KorisnikFilterParametar
    {
    
    	public KorisnikFilterParametarItem() {}
    	public KorisnikFilterParametarItem(long id_KorisnikFilterParametar)
    	{
    		ID_KorisnikFilterParametar = id_KorisnikFilterParametar;
    	}
        public long ID
    	{
    		get { return this.ID_KorisnikFilterParametar; }
    		set { this.ID_KorisnikFilterParametar = value; }
    	}
        public long ID_KorisnikFilterParametar { get; set; }
        public long ID_KorisnikFilter { get; set; }
        public string Naziv { get; set; }
        public bool? ValueBit { get; set; }
        public string ValueString { get; set; }
        public int? ValueInt { get; set; }
        public decimal? Value { get; set; }
        public DateTime? ValueDate { get; set; }
        public TimeSpan? ValueTime { get; set; }
        public DateTime? ValueDateTime { get; set; }
        public decimal? ValueDecimal { get; set; }
    }
}

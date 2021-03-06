//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class OsobaPrezimeItem 
    {
    
    	public OsobaPrezimeItem() {}
    	public OsobaPrezimeItem(long? id_OsobaPrezime)
    	{
    		ID_OsobaPrezime = id_OsobaPrezime;
    	}
    
        public long? ID
    	{
    		get { return this.ID_OsobaPrezime; }
    		set { this.ID_OsobaPrezime = value; }
    	}
        public long? ID_OsobaPrezime { get; set; }
        public long? ID_Osoba { get; set; }
        public int? RedniBroj { get; set; }
        public bool? Aktivno { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public string Prezime { get; set; }
    
    	public OsobaPrezimeItem(Model.Data.OsobaPrezime item)
    	{
    	    this.ID_OsobaPrezime = item.ID_OsobaPrezime;
        this.ID_Osoba = item.ID_Osoba;
        this.RedniBroj = item.RedniBroj;
        this.Aktivno = item.Aktivno;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.Prezime = item.Prezime;
    	}
    
    	public OsobaPrezimeItem(dynamic item)
    	{
    	    this.ID_OsobaPrezime = item.ID_OsobaPrezime;
        this.ID_Osoba = item.ID_Osoba;
        this.RedniBroj = item.RedniBroj;
        this.Aktivno = item.Aktivno;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.Prezime = item.Prezime;
    	}
    }
}

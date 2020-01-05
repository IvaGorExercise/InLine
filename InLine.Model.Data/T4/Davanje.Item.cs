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
    
    public partial class DavanjeItem 
    {
    
    	public DavanjeItem() {}
    	public DavanjeItem(long? id_Davanje)
    	{
    		ID_Davanje = id_Davanje;
    	}
    
        public long? ID
    	{
    		get { return this.ID_Davanje; }
    		set { this.ID_Davanje = value; }
    	}
        public long? ID_Davanje { get; set; }
        public int? IDDavanjeTablica { get; set; }
        public long? IDDavanje { get; set; }
        public string Naziv { get; set; }
        public decimal? Stopa { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public decimal? IznosOd { get; set; }
        public decimal? IznosDo { get; set; }
    
    	public DavanjeItem(Model.Data.Davanje item)
    	{
    	    this.ID_Davanje = item.ID_Davanje;
        this.IDDavanjeTablica = item.IDDavanjeTablica;
        this.IDDavanje = item.IDDavanje;
        this.Naziv = item.Naziv;
        this.Stopa = item.Stopa;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.IznosOd = item.IznosOd;
        this.IznosDo = item.IznosDo;
    	}
    
    	public DavanjeItem(dynamic item)
    	{
    	    this.ID_Davanje = item.ID_Davanje;
        this.IDDavanjeTablica = item.IDDavanjeTablica;
        this.IDDavanje = item.IDDavanje;
        this.Naziv = item.Naziv;
        this.Stopa = item.Stopa;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.IznosOd = item.IznosOd;
        this.IznosDo = item.IznosDo;
    	}
    }
}
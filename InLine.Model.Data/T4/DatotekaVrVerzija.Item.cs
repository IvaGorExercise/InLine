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
    
    public partial class DatotekaVrVerzijaItem 
    {
    
    	public DatotekaVrVerzijaItem() {}
    	public DatotekaVrVerzijaItem(long? id_DatotekaVrVerzija)
    	{
    		ID_DatotekaVrVerzija = id_DatotekaVrVerzija;
    	}
    
        public long? ID
    	{
    		get { return this.ID_DatotekaVrVerzija; }
    		set { this.ID_DatotekaVrVerzija = value; }
    	}
        public long? ID_DatotekaVrVerzija { get; set; }
        public long? ID_DatotekaVr { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
    
    	public DatotekaVrVerzijaItem(Model.Data.DatotekaVrVerzija item)
    	{
    	    this.ID_DatotekaVrVerzija = item.ID_DatotekaVrVerzija;
        this.ID_DatotekaVr = item.ID_DatotekaVr;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
    	}
    
    	public DatotekaVrVerzijaItem(dynamic item)
    	{
    	    this.ID_DatotekaVrVerzija = item.ID_DatotekaVrVerzija;
        this.ID_DatotekaVr = item.ID_DatotekaVr;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
    	}
    }
}
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
    
    public partial class OsobaBoravisteItem 
    {
    
    	public OsobaBoravisteItem() {}
    	public OsobaBoravisteItem(long? id_OsobaBoraviste)
    	{
    		ID_OsobaBoraviste = id_OsobaBoraviste;
    	}
    
        public long? ID
    	{
    		get { return this.ID_OsobaBoraviste; }
    		set { this.ID_OsobaBoraviste = value; }
    	}
        public long? ID_OsobaBoraviste { get; set; }
        public long? ID_Osoba { get; set; }
        public long? ID_Opcina { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
    
    	public OsobaBoravisteItem(Model.Data.OsobaBoraviste item)
    	{
    	    this.ID_OsobaBoraviste = item.ID_OsobaBoraviste;
        this.ID_Osoba = item.ID_Osoba;
        this.ID_Opcina = item.ID_Opcina;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
    	}
    
    	public OsobaBoravisteItem(dynamic item)
    	{
    	    this.ID_OsobaBoraviste = item.ID_OsobaBoraviste;
        this.ID_Osoba = item.ID_Osoba;
        this.ID_Opcina = item.ID_Opcina;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
    	}
    }
}

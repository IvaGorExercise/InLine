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
    
    public partial class ObrazacIPItem 
    {
    
    	public ObrazacIPItem() {}
    	public ObrazacIPItem(long? id_ObrazacIP)
    	{
    		ID_ObrazacIP = id_ObrazacIP;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ObrazacIP; }
    		set { this.ID_ObrazacIP = value; }
    	}
        public long? ID_ObrazacIP { get; set; }
        public long? ID_Zapis { get; set; }
        public long? ID_DohodakIsplatitelj { get; set; }
        public long? ID_Osoba { get; set; }
        public int? Godina { get; set; }
        public int? IDObrazacIPVerzija { get; set; }
        public string DatotekaNaziv { get; set; }
        public string Datoteka { get; set; }
    
    	public ObrazacIPItem(Model.Data.ObrazacIP item)
    	{
    	    this.ID_ObrazacIP = item.ID_ObrazacIP;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_DohodakIsplatitelj = item.ID_DohodakIsplatitelj;
        this.ID_Osoba = item.ID_Osoba;
        this.Godina = item.Godina;
        this.IDObrazacIPVerzija = item.IDObrazacIPVerzija;
        this.DatotekaNaziv = item.DatotekaNaziv;
        this.Datoteka = item.Datoteka;
    	}
    
    	public ObrazacIPItem(dynamic item)
    	{
    	    this.ID_ObrazacIP = item.ID_ObrazacIP;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_DohodakIsplatitelj = item.ID_DohodakIsplatitelj;
        this.ID_Osoba = item.ID_Osoba;
        this.Godina = item.Godina;
        this.IDObrazacIPVerzija = item.IDObrazacIPVerzija;
        this.DatotekaNaziv = item.DatotekaNaziv;
        this.Datoteka = item.Datoteka;
    	}
    }
}
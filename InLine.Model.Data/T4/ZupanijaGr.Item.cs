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
    
    public partial class ZupanijaGrItem 
    {
    
    	public ZupanijaGrItem() {}
    	public ZupanijaGrItem(long? id_ZupanijaGr)
    	{
    		ID_ZupanijaGr = id_ZupanijaGr;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ZupanijaGr; }
    		set { this.ID_ZupanijaGr = value; }
    	}
        public long? ID_ZupanijaGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
        public long? ID_ZupanijaGrTip { get; set; }
    
    	public ZupanijaGrItem(Model.Data.ZupanijaGr item)
    	{
    	    this.ID_ZupanijaGr = item.ID_ZupanijaGr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
        this.ID_ZupanijaGrTip = item.ID_ZupanijaGrTip;
    	}
    
    	public ZupanijaGrItem(dynamic item)
    	{
    	    this.ID_ZupanijaGr = item.ID_ZupanijaGr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
        this.ID_ZupanijaGrTip = item.ID_ZupanijaGrTip;
    	}
    }
}

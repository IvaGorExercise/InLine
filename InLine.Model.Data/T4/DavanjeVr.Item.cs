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
    
    public partial class DavanjeVrItem 
    {
    
    	public DavanjeVrItem() {}
    	public DavanjeVrItem(int? idDavanjeVr)
    	{
    		IDDavanjeVr = idDavanjeVr;
    	}
    
        public int? IDDavanjeVr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public DavanjeVrItem(Model.Data.DavanjeVr item)
    	{
    	    this.IDDavanjeVr = item.IDDavanjeVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public DavanjeVrItem(dynamic item)
    	{
    	    this.IDDavanjeVr = item.IDDavanjeVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}

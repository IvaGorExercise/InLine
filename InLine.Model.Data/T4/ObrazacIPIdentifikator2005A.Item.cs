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
    
    public partial class ObrazacIPIdentifikator2005AItem 
    {
    
    	public ObrazacIPIdentifikator2005AItem() {}
    	public ObrazacIPIdentifikator2005AItem(int? idObrazacIPIdentifikator2005A)
    	{
    		IDObrazacIPIdentifikator2005A = idObrazacIPIdentifikator2005A;
    	}
    
        public int? IDObrazacIPIdentifikator2005A { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
    
    	public ObrazacIPIdentifikator2005AItem(Model.Data.ObrazacIPIdentifikator2005A item)
    	{
    	    this.IDObrazacIPIdentifikator2005A = item.IDObrazacIPIdentifikator2005A;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    
    	public ObrazacIPIdentifikator2005AItem(dynamic item)
    	{
    	    this.IDObrazacIPIdentifikator2005A = item.IDObrazacIPIdentifikator2005A;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    }
}

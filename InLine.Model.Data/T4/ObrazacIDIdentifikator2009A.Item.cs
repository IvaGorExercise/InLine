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
    
    public partial class ObrazacIDIdentifikator2009AItem 
    {
    
    	public ObrazacIDIdentifikator2009AItem() {}
    	public ObrazacIDIdentifikator2009AItem(int? idObrazacIDIdentifikator2009A)
    	{
    		IDObrazacIDIdentifikator2009A = idObrazacIDIdentifikator2009A;
    	}
    
        public int? IDObrazacIDIdentifikator2009A { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public ObrazacIDIdentifikator2009AItem(Model.Data.ObrazacIDIdentifikator2009A item)
    	{
    	    this.IDObrazacIDIdentifikator2009A = item.IDObrazacIDIdentifikator2009A;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public ObrazacIDIdentifikator2009AItem(dynamic item)
    	{
    	    this.IDObrazacIDIdentifikator2009A = item.IDObrazacIDIdentifikator2009A;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}

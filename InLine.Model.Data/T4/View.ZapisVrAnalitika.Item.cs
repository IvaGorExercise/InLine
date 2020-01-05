//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Item.View
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZapisVrAnalitikaItem 
    {
    
    	public ZapisVrAnalitikaItem() {}
    	public ZapisVrAnalitikaItem(int? idZapisVr, string oznaka, string naziv, string nazivKr, string kratica, bool? analitika)
    	{
    		IDZapisVr = idZapisVr;
    		Oznaka = oznaka;
    		Naziv = naziv;
    		NazivKr = nazivKr;
    		Kratica = kratica;
    		Analitika = analitika;
    	}
    
        public int? IDZapisVr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public bool? Odabir { get; set; }
        public bool? Analitika { get; set; }
    
    	public ZapisVrAnalitikaItem(Model.Data.View.ZapisVrAnalitika item)
    	{
    	    this.IDZapisVr = item.IDZapisVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Odabir = item.Odabir;
        this.Analitika = item.Analitika;
    	}
    
    	public ZapisVrAnalitikaItem(dynamic item)
    	{
    	    this.IDZapisVr = item.IDZapisVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Odabir = item.Odabir;
        this.Analitika = item.Analitika;
    	}
    }
}
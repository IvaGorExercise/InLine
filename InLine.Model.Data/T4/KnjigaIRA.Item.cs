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
    
    public partial class KnjigaIRAItem 
    {
    
    	public KnjigaIRAItem() {}
    	public KnjigaIRAItem(long? id_KnjigaIRA)
    	{
    		ID_KnjigaIRA = id_KnjigaIRA;
    	}
    
        public long? ID
    	{
    		get { return this.ID_KnjigaIRA; }
    		set { this.ID_KnjigaIRA = value; }
    	}
        public long? ID_KnjigaIRA { get; set; }
        public long? ID_Zapis { get; set; }
        public long? ID_PoslovnaGodina { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public long? ID_RacunIzlaz { get; set; }
        public decimal? IznosProlaznaSt { get; set; }
        public decimal? IznosNeoporezivo { get; set; }
        public decimal? IznosIzvoz { get; set; }
        public decimal? IznosMedunarodniPrijevoz { get; set; }
        public decimal? IznosTuzemstvo { get; set; }
        public decimal? IznosOstalo { get; set; }
    
    	public KnjigaIRAItem(Model.Data.KnjigaIRA item)
    	{
    	    this.ID_KnjigaIRA = item.ID_KnjigaIRA;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_PoslovnaGodina = item.ID_PoslovnaGodina;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.ID_RacunIzlaz = item.ID_RacunIzlaz;
        this.IznosProlaznaSt = item.IznosProlaznaSt;
        this.IznosNeoporezivo = item.IznosNeoporezivo;
        this.IznosIzvoz = item.IznosIzvoz;
        this.IznosMedunarodniPrijevoz = item.IznosMedunarodniPrijevoz;
        this.IznosTuzemstvo = item.IznosTuzemstvo;
        this.IznosOstalo = item.IznosOstalo;
    	}
    
    	public KnjigaIRAItem(dynamic item)
    	{
    	    this.ID_KnjigaIRA = item.ID_KnjigaIRA;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_PoslovnaGodina = item.ID_PoslovnaGodina;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.ID_RacunIzlaz = item.ID_RacunIzlaz;
        this.IznosProlaznaSt = item.IznosProlaznaSt;
        this.IznosNeoporezivo = item.IznosNeoporezivo;
        this.IznosIzvoz = item.IznosIzvoz;
        this.IznosMedunarodniPrijevoz = item.IznosMedunarodniPrijevoz;
        this.IznosTuzemstvo = item.IznosTuzemstvo;
        this.IznosOstalo = item.IznosOstalo;
    	}
    }
}

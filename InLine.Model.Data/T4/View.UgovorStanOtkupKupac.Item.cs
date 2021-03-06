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
    
    public partial class UgovorStanOtkupKupacItem 
    {
    
    	public UgovorStanOtkupKupacItem() {}
    	public UgovorStanOtkupKupacItem(long? id_Kupac, long? id_UgovorStanOtkup, int? brojUgovor)
    	{
    		ID_Kupac = id_Kupac;
    		ID_UgovorStanOtkup = id_UgovorStanOtkup;
    		BrojUgovor = brojUgovor;
    	}
    
        public long? ID_Kupac { get; set; }
        public string Naziv { get; set; }
        public long? ID_UgovorStanOtkup { get; set; }
        public int? BrojUgovor { get; set; }
        public long? ID_UgovorStanOtkupKupac { get; set; }
        public string JMBG { get; set; }
        public string OIB { get; set; }
        public bool? Nositelj { get; set; }
        public string Ulica { get; set; }
        public string KucniBroj { get; set; }
        public string KucniBrojDodatak { get; set; }
        public string PostanskiBroj { get; set; }
    
    	public UgovorStanOtkupKupacItem(Model.Data.View.UgovorStanOtkupKupac item)
    	{
    	    this.ID_Kupac = item.ID_Kupac;
        this.Naziv = item.Naziv;
        this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.BrojUgovor = item.BrojUgovor;
        this.ID_UgovorStanOtkupKupac = item.ID_UgovorStanOtkupKupac;
        this.JMBG = item.JMBG;
        this.OIB = item.OIB;
        this.Nositelj = item.Nositelj;
        this.Ulica = item.Ulica;
        this.KucniBroj = item.KucniBroj;
        this.KucniBrojDodatak = item.KucniBrojDodatak;
        this.PostanskiBroj = item.PostanskiBroj;
    	}
    
    	public UgovorStanOtkupKupacItem(dynamic item)
    	{
    	    this.ID_Kupac = item.ID_Kupac;
        this.Naziv = item.Naziv;
        this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.BrojUgovor = item.BrojUgovor;
        this.ID_UgovorStanOtkupKupac = item.ID_UgovorStanOtkupKupac;
        this.JMBG = item.JMBG;
        this.OIB = item.OIB;
        this.Nositelj = item.Nositelj;
        this.Ulica = item.Ulica;
        this.KucniBroj = item.KucniBroj;
        this.KucniBrojDodatak = item.KucniBrojDodatak;
        this.PostanskiBroj = item.PostanskiBroj;
    	}
    }
}

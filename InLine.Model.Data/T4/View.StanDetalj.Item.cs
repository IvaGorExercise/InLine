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
    
    public partial class StanDetaljItem 
    {
    
    	public StanDetaljItem() {}
    	public StanDetaljItem(long? id_Stan, string oznaka, string naziv, string nazivKr, string kratica)
    	{
    		ID_Stan = id_Stan;
    		Oznaka = oznaka;
    		Naziv = naziv;
    		NazivKr = nazivKr;
    		Kratica = kratica;
    	}
    
        public long? ID_Stan { get; set; }
        public long? ID_Objekt { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public decimal? Povrsina { get; set; }
        public decimal? BrojSoba { get; set; }
        public string Broj { get; set; }
        public string Ulica { get; set; }
        public string KucniBrojDodatak { get; set; }
        public string KucniBroj { get; set; }
        public string Kat { get; set; }
        public long? ID_Zgrada { get; set; }
        public string Opis { get; set; }
        public string KatastarskaCestica { get; set; }
        public string KatastarskaCesticaOpcina { get; set; }
        public long? ID_Adresa { get; set; }
        public int? BrojUgovor { get; set; }
        public string PostanskiBroj { get; set; }
        public string Posta { get; set; }
        public long? ID_Posta { get; set; }
    
    	public StanDetaljItem(Model.Data.View.StanDetalj item)
    	{
    	    this.ID_Stan = item.ID_Stan;
        this.ID_Objekt = item.ID_Objekt;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Povrsina = item.Povrsina;
        this.BrojSoba = item.BrojSoba;
        this.Broj = item.Broj;
        this.Ulica = item.Ulica;
        this.KucniBrojDodatak = item.KucniBrojDodatak;
        this.KucniBroj = item.KucniBroj;
        this.Kat = item.Kat;
        this.ID_Zgrada = item.ID_Zgrada;
        this.Opis = item.Opis;
        this.KatastarskaCestica = item.KatastarskaCestica;
        this.KatastarskaCesticaOpcina = item.KatastarskaCesticaOpcina;
        this.ID_Adresa = item.ID_Adresa;
        this.BrojUgovor = item.BrojUgovor;
        this.PostanskiBroj = item.PostanskiBroj;
        this.Posta = item.Posta;
        this.ID_Posta = item.ID_Posta;
    	}
    
    	public StanDetaljItem(dynamic item)
    	{
    	    this.ID_Stan = item.ID_Stan;
        this.ID_Objekt = item.ID_Objekt;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Povrsina = item.Povrsina;
        this.BrojSoba = item.BrojSoba;
        this.Broj = item.Broj;
        this.Ulica = item.Ulica;
        this.KucniBrojDodatak = item.KucniBrojDodatak;
        this.KucniBroj = item.KucniBroj;
        this.Kat = item.Kat;
        this.ID_Zgrada = item.ID_Zgrada;
        this.Opis = item.Opis;
        this.KatastarskaCestica = item.KatastarskaCestica;
        this.KatastarskaCesticaOpcina = item.KatastarskaCesticaOpcina;
        this.ID_Adresa = item.ID_Adresa;
        this.BrojUgovor = item.BrojUgovor;
        this.PostanskiBroj = item.PostanskiBroj;
        this.Posta = item.Posta;
        this.ID_Posta = item.ID_Posta;
    	}
    }
}

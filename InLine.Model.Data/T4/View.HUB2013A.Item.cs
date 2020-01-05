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
    
    public partial class HUB2013AItem 
    {
    
    	public HUB2013AItem() {}
    	public HUB2013AItem(long? id_HUB2013A, long? id_HUB, int? idHUBNalogVrsta2013A, string idValutaPlacanje, string primateljNaziv, string primateljRacun, decimal? iznos, int? brojUgovor, int? brojObrok, long? id_HUBImportHUB, int? godina, int? mjesec, long? id_HUBImport)
    	{
    		ID_HUB2013A = id_HUB2013A;
    		ID_HUB = id_HUB;
    		IDHUBNalogVrsta2013A = idHUBNalogVrsta2013A;
    		IDValutaPlacanje = idValutaPlacanje;
    		PrimateljNaziv = primateljNaziv;
    		PrimateljRacun = primateljRacun;
    		Iznos = iznos;
    		BrojUgovor = brojUgovor;
    		BrojObrok = brojObrok;
    		ID_HUBImportHUB = id_HUBImportHUB;
    		Godina = godina;
    		Mjesec = mjesec;
    		ID_HUBImport = id_HUBImport;
    	}
    
        public long? ID_HUB2013A { get; set; }
        public long? ID_HUB { get; set; }
        public int? IDHUBNalogVrsta2013A { get; set; }
        public int? IDHUBModel2013APlatitelj { get; set; }
        public int? IDHUBModel2013APrimatelj { get; set; }
        public string IDValutaPlacanje { get; set; }
        public string IDValutaPokrice { get; set; }
        public int? IDHUBNamjena2013A { get; set; }
        public string IDHUBNamjena2013AOznaka { get; set; }
        public string IDHUBNamjena2013ANaziv { get; set; }
        public int? IDHUBPrimateljVrsta2013A { get; set; }
        public string IDHUBPrimateljVrsta2013AOznaka { get; set; }
        public string IDHUBPrimateljVrsta2013ANaziv { get; set; }
        public int? IDHUBTroskoviOpcija2013A { get; set; }
        public string IDHUBTroskoviOpcija2013AOznaka { get; set; }
        public string IDHUBTroskoviOpcija2013ANaziv { get; set; }
        public long? ID_StornoHUB2013A { get; set; }
        public string IDDrzavaPrimatelj { get; set; }
        public string IDDrzavaBanka { get; set; }
        public string PlatiteljNaziv { get; set; }
        public string PlatiteljAdresa { get; set; }
        public string PlatiteljSjediste { get; set; }
        public string PlatiteljRacun { get; set; }
        public string PlatiteljPozivNaBroj { get; set; }
        public string PrimateljNaziv { get; set; }
        public string PrimateljAdresa { get; set; }
        public string PrimateljSjediste { get; set; }
        public string PrimateljRacun { get; set; }
        public string PrimateljPozivNaBroj { get; set; }
        public decimal? Iznos { get; set; }
        public string OpisPlacanje { get; set; }
        public string OpisPlacanjePlatitelj { get; set; }
        public bool? Hitno { get; set; }
        public string SWIFT { get; set; }
        public string BankaNaziv { get; set; }
        public string BankaAdresa { get; set; }
        public string BankaSjediste { get; set; }
        public bool? Storno { get; set; }
        public string HUBModel2013APlatiteljOznaka { get; set; }
        public string HUBModel2013APlatiteljPredOznaka { get; set; }
        public string HUBModel2013APrimateljOznaka { get; set; }
        public string HUBModel2013APrimateljPredOznaka { get; set; }
        public string DrzavaPrimateljSif { get; set; }
        public string DrzavaBankaSif { get; set; }
        public int? BrojUgovor { get; set; }
        public int? BrojObrok { get; set; }
        public long? ID_HUBImportHUB { get; set; }
        public int? Godina { get; set; }
        public int? Mjesec { get; set; }
        public long? ID_HUBImport { get; set; }
        public DateTime? DatumIzvrsenje { get; set; }
        public DateTime? DatumDospijece { get; set; }
    
    	public HUB2013AItem(Model.Data.View.HUB2013A item)
    	{
    	    this.ID_HUB2013A = item.ID_HUB2013A;
        this.ID_HUB = item.ID_HUB;
        this.IDHUBNalogVrsta2013A = item.IDHUBNalogVrsta2013A;
        this.IDHUBModel2013APlatitelj = item.IDHUBModel2013APlatitelj;
        this.IDHUBModel2013APrimatelj = item.IDHUBModel2013APrimatelj;
        this.IDValutaPlacanje = item.IDValutaPlacanje;
        this.IDValutaPokrice = item.IDValutaPokrice;
        this.IDHUBNamjena2013A = item.IDHUBNamjena2013A;
        this.IDHUBNamjena2013AOznaka = item.IDHUBNamjena2013AOznaka;
        this.IDHUBNamjena2013ANaziv = item.IDHUBNamjena2013ANaziv;
        this.IDHUBPrimateljVrsta2013A = item.IDHUBPrimateljVrsta2013A;
        this.IDHUBPrimateljVrsta2013AOznaka = item.IDHUBPrimateljVrsta2013AOznaka;
        this.IDHUBPrimateljVrsta2013ANaziv = item.IDHUBPrimateljVrsta2013ANaziv;
        this.IDHUBTroskoviOpcija2013A = item.IDHUBTroskoviOpcija2013A;
        this.IDHUBTroskoviOpcija2013AOznaka = item.IDHUBTroskoviOpcija2013AOznaka;
        this.IDHUBTroskoviOpcija2013ANaziv = item.IDHUBTroskoviOpcija2013ANaziv;
        this.ID_StornoHUB2013A = item.ID_StornoHUB2013A;
        this.IDDrzavaPrimatelj = item.IDDrzavaPrimatelj;
        this.IDDrzavaBanka = item.IDDrzavaBanka;
        this.PlatiteljNaziv = item.PlatiteljNaziv;
        this.PlatiteljAdresa = item.PlatiteljAdresa;
        this.PlatiteljSjediste = item.PlatiteljSjediste;
        this.PlatiteljRacun = item.PlatiteljRacun;
        this.PlatiteljPozivNaBroj = item.PlatiteljPozivNaBroj;
        this.PrimateljNaziv = item.PrimateljNaziv;
        this.PrimateljAdresa = item.PrimateljAdresa;
        this.PrimateljSjediste = item.PrimateljSjediste;
        this.PrimateljRacun = item.PrimateljRacun;
        this.PrimateljPozivNaBroj = item.PrimateljPozivNaBroj;
        this.Iznos = item.Iznos;
        this.OpisPlacanje = item.OpisPlacanje;
        this.OpisPlacanjePlatitelj = item.OpisPlacanjePlatitelj;
        this.Hitno = item.Hitno;
        this.SWIFT = item.SWIFT;
        this.BankaNaziv = item.BankaNaziv;
        this.BankaAdresa = item.BankaAdresa;
        this.BankaSjediste = item.BankaSjediste;
        this.Storno = item.Storno;
        this.HUBModel2013APlatiteljOznaka = item.HUBModel2013APlatiteljOznaka;
        this.HUBModel2013APlatiteljPredOznaka = item.HUBModel2013APlatiteljPredOznaka;
        this.HUBModel2013APrimateljOznaka = item.HUBModel2013APrimateljOznaka;
        this.HUBModel2013APrimateljPredOznaka = item.HUBModel2013APrimateljPredOznaka;
        this.DrzavaPrimateljSif = item.DrzavaPrimateljSif;
        this.DrzavaBankaSif = item.DrzavaBankaSif;
        this.BrojUgovor = item.BrojUgovor;
        this.BrojObrok = item.BrojObrok;
        this.ID_HUBImportHUB = item.ID_HUBImportHUB;
        this.Godina = item.Godina;
        this.Mjesec = item.Mjesec;
        this.ID_HUBImport = item.ID_HUBImport;
        this.DatumIzvrsenje = item.DatumIzvrsenje;
        this.DatumDospijece = item.DatumDospijece;
    	}
    
    	public HUB2013AItem(dynamic item)
    	{
    	    this.ID_HUB2013A = item.ID_HUB2013A;
        this.ID_HUB = item.ID_HUB;
        this.IDHUBNalogVrsta2013A = item.IDHUBNalogVrsta2013A;
        this.IDHUBModel2013APlatitelj = item.IDHUBModel2013APlatitelj;
        this.IDHUBModel2013APrimatelj = item.IDHUBModel2013APrimatelj;
        this.IDValutaPlacanje = item.IDValutaPlacanje;
        this.IDValutaPokrice = item.IDValutaPokrice;
        this.IDHUBNamjena2013A = item.IDHUBNamjena2013A;
        this.IDHUBNamjena2013AOznaka = item.IDHUBNamjena2013AOznaka;
        this.IDHUBNamjena2013ANaziv = item.IDHUBNamjena2013ANaziv;
        this.IDHUBPrimateljVrsta2013A = item.IDHUBPrimateljVrsta2013A;
        this.IDHUBPrimateljVrsta2013AOznaka = item.IDHUBPrimateljVrsta2013AOznaka;
        this.IDHUBPrimateljVrsta2013ANaziv = item.IDHUBPrimateljVrsta2013ANaziv;
        this.IDHUBTroskoviOpcija2013A = item.IDHUBTroskoviOpcija2013A;
        this.IDHUBTroskoviOpcija2013AOznaka = item.IDHUBTroskoviOpcija2013AOznaka;
        this.IDHUBTroskoviOpcija2013ANaziv = item.IDHUBTroskoviOpcija2013ANaziv;
        this.ID_StornoHUB2013A = item.ID_StornoHUB2013A;
        this.IDDrzavaPrimatelj = item.IDDrzavaPrimatelj;
        this.IDDrzavaBanka = item.IDDrzavaBanka;
        this.PlatiteljNaziv = item.PlatiteljNaziv;
        this.PlatiteljAdresa = item.PlatiteljAdresa;
        this.PlatiteljSjediste = item.PlatiteljSjediste;
        this.PlatiteljRacun = item.PlatiteljRacun;
        this.PlatiteljPozivNaBroj = item.PlatiteljPozivNaBroj;
        this.PrimateljNaziv = item.PrimateljNaziv;
        this.PrimateljAdresa = item.PrimateljAdresa;
        this.PrimateljSjediste = item.PrimateljSjediste;
        this.PrimateljRacun = item.PrimateljRacun;
        this.PrimateljPozivNaBroj = item.PrimateljPozivNaBroj;
        this.Iznos = item.Iznos;
        this.OpisPlacanje = item.OpisPlacanje;
        this.OpisPlacanjePlatitelj = item.OpisPlacanjePlatitelj;
        this.Hitno = item.Hitno;
        this.SWIFT = item.SWIFT;
        this.BankaNaziv = item.BankaNaziv;
        this.BankaAdresa = item.BankaAdresa;
        this.BankaSjediste = item.BankaSjediste;
        this.Storno = item.Storno;
        this.HUBModel2013APlatiteljOznaka = item.HUBModel2013APlatiteljOznaka;
        this.HUBModel2013APlatiteljPredOznaka = item.HUBModel2013APlatiteljPredOznaka;
        this.HUBModel2013APrimateljOznaka = item.HUBModel2013APrimateljOznaka;
        this.HUBModel2013APrimateljPredOznaka = item.HUBModel2013APrimateljPredOznaka;
        this.DrzavaPrimateljSif = item.DrzavaPrimateljSif;
        this.DrzavaBankaSif = item.DrzavaBankaSif;
        this.BrojUgovor = item.BrojUgovor;
        this.BrojObrok = item.BrojObrok;
        this.ID_HUBImportHUB = item.ID_HUBImportHUB;
        this.Godina = item.Godina;
        this.Mjesec = item.Mjesec;
        this.ID_HUBImport = item.ID_HUBImport;
        this.DatumIzvrsenje = item.DatumIzvrsenje;
        this.DatumDospijece = item.DatumDospijece;
    	}
    }
}
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
    
    public partial class TemeljnicaDetaljItem 
    {
    
    	public TemeljnicaDetaljItem() {}
    	public TemeljnicaDetaljItem(long? id_Temeljnica, long? id_TemeljnicaVr, string naziv, DateTime? datum, string idValuta, bool? knjizeno, bool? storno, bool? pocetnoStanje, bool? zavrsnoKnjizenje, string oznaka, string nazivKr, string kratica, decimal? tecaj)
    	{
    		ID_Temeljnica = id_Temeljnica;
    		ID_TemeljnicaVr = id_TemeljnicaVr;
    		Naziv = naziv;
    		Datum = datum;
    		IDValuta = idValuta;
    		Knjizeno = knjizeno;
    		Storno = storno;
    		PocetnoStanje = pocetnoStanje;
    		ZavrsnoKnjizenje = zavrsnoKnjizenje;
    		Oznaka = oznaka;
    		NazivKr = nazivKr;
    		Kratica = kratica;
    		Tecaj = tecaj;
    	}
    
        public long? ID_Temeljnica { get; set; }
        public long? ID_TemeljnicaVr { get; set; }
        public string Naziv { get; set; }
        public DateTime? Datum { get; set; }
        public string IDValuta { get; set; }
        public bool? Knjizeno { get; set; }
        public bool? Storno { get; set; }
        public bool? PocetnoStanje { get; set; }
        public bool? ZavrsnoKnjizenje { get; set; }
        public string Oznaka { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public DateTime? DatumKnjizenje { get; set; }
        public decimal? Tecaj { get; set; }
        public string Opis { get; set; }
        public decimal? SumIznosDuguje { get; set; }
        public decimal? SumIznosPotrazuje { get; set; }
        public decimal? SumIznosDugujeValuta { get; set; }
        public decimal? SumIznosPotrazujeValuta { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? SaldoValuta { get; set; }
    
    	public TemeljnicaDetaljItem(Model.Data.View.TemeljnicaDetalj item)
    	{
    	    this.ID_Temeljnica = item.ID_Temeljnica;
        this.ID_TemeljnicaVr = item.ID_TemeljnicaVr;
        this.Naziv = item.Naziv;
        this.Datum = item.Datum;
        this.IDValuta = item.IDValuta;
        this.Knjizeno = item.Knjizeno;
        this.Storno = item.Storno;
        this.PocetnoStanje = item.PocetnoStanje;
        this.ZavrsnoKnjizenje = item.ZavrsnoKnjizenje;
        this.Oznaka = item.Oznaka;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.DatumKnjizenje = item.DatumKnjizenje;
        this.Tecaj = item.Tecaj;
        this.Opis = item.Opis;
        this.SumIznosDuguje = item.SumIznosDuguje;
        this.SumIznosPotrazuje = item.SumIznosPotrazuje;
        this.SumIznosDugujeValuta = item.SumIznosDugujeValuta;
        this.SumIznosPotrazujeValuta = item.SumIznosPotrazujeValuta;
        this.Saldo = item.Saldo;
        this.SaldoValuta = item.SaldoValuta;
    	}
    
    	public TemeljnicaDetaljItem(dynamic item)
    	{
    	    this.ID_Temeljnica = item.ID_Temeljnica;
        this.ID_TemeljnicaVr = item.ID_TemeljnicaVr;
        this.Naziv = item.Naziv;
        this.Datum = item.Datum;
        this.IDValuta = item.IDValuta;
        this.Knjizeno = item.Knjizeno;
        this.Storno = item.Storno;
        this.PocetnoStanje = item.PocetnoStanje;
        this.ZavrsnoKnjizenje = item.ZavrsnoKnjizenje;
        this.Oznaka = item.Oznaka;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.DatumKnjizenje = item.DatumKnjizenje;
        this.Tecaj = item.Tecaj;
        this.Opis = item.Opis;
        this.SumIznosDuguje = item.SumIznosDuguje;
        this.SumIznosPotrazuje = item.SumIznosPotrazuje;
        this.SumIznosDugujeValuta = item.SumIznosDugujeValuta;
        this.SumIznosPotrazujeValuta = item.SumIznosPotrazujeValuta;
        this.Saldo = item.Saldo;
        this.SaldoValuta = item.SaldoValuta;
    	}
    }
}

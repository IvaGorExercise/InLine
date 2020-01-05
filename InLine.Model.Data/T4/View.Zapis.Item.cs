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
    
    public partial class ZapisItem 
    {
    
    	public ZapisItem() {}
    	public ZapisItem(string tablicaNaziv, string datumGodina, string datumString)
    	{
    		TablicaNaziv = tablicaNaziv;
    		DatumGodina = datumGodina;
    		DatumString = datumString;
    	}
    
        public long? ID_Zapis { get; set; }
        public int? IDZapisTablica { get; set; }
        public int? IDZapisVr { get; set; }
        public long? IDZapis { get; set; }
        public DateTime? VrijemeUpis { get; set; }
        public string UrudzbeniBroj { get; set; }
        public string Predmet { get; set; }
        public long? ID_Subjekt { get; set; }
        public long? ID_SubjektUpis { get; set; }
        public long? ID_Temeljnica { get; set; }
        public string Broj { get; set; }
        public DateTime? Datum { get; set; }
        public TimeSpan? Vrijeme { get; set; }
        public string TablicaNaziv { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public bool? Odabir { get; set; }
        public string DatumGodina { get; set; }
        public string VrijemeUpisString { get; set; }
        public string DatumString { get; set; }
    
    	public ZapisItem(Model.Data.View.Zapis item)
    	{
    	    this.ID_Zapis = item.ID_Zapis;
        this.IDZapisTablica = item.IDZapisTablica;
        this.IDZapisVr = item.IDZapisVr;
        this.IDZapis = item.IDZapis;
        this.VrijemeUpis = item.VrijemeUpis;
        this.UrudzbeniBroj = item.UrudzbeniBroj;
        this.Predmet = item.Predmet;
        this.ID_Subjekt = item.ID_Subjekt;
        this.ID_SubjektUpis = item.ID_SubjektUpis;
        this.ID_Temeljnica = item.ID_Temeljnica;
        this.Broj = item.Broj;
        this.Datum = item.Datum;
        this.Vrijeme = item.Vrijeme;
        this.TablicaNaziv = item.TablicaNaziv;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Odabir = item.Odabir;
        this.DatumGodina = item.DatumGodina;
        this.VrijemeUpisString = item.VrijemeUpisString;
        this.DatumString = item.DatumString;
    	}
    
    	public ZapisItem(dynamic item)
    	{
    	    this.ID_Zapis = item.ID_Zapis;
        this.IDZapisTablica = item.IDZapisTablica;
        this.IDZapisVr = item.IDZapisVr;
        this.IDZapis = item.IDZapis;
        this.VrijemeUpis = item.VrijemeUpis;
        this.UrudzbeniBroj = item.UrudzbeniBroj;
        this.Predmet = item.Predmet;
        this.ID_Subjekt = item.ID_Subjekt;
        this.ID_SubjektUpis = item.ID_SubjektUpis;
        this.ID_Temeljnica = item.ID_Temeljnica;
        this.Broj = item.Broj;
        this.Datum = item.Datum;
        this.Vrijeme = item.Vrijeme;
        this.TablicaNaziv = item.TablicaNaziv;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Odabir = item.Odabir;
        this.DatumGodina = item.DatumGodina;
        this.VrijemeUpisString = item.VrijemeUpisString;
        this.DatumString = item.DatumString;
    	}
    }
}

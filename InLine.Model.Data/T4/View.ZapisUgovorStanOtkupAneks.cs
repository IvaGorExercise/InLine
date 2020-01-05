//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.View
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZapisUgovorStanOtkupAneks
    {
    
        public int IDZapisTablica { get; set; }
        public int? IDZapisVr { get; set; }
        public long ID_Zapis { get; set; }
        public long IDZapis { get; set; }
        public DateTime? VrijemeUpis { get; set; }
        public string UrudzbeniBroj { get; set; }
        public string Predmet { get; set; }
        public long? ID_Subjekt { get; set; }
        public long? ID_SubjektUpis { get; set; }
        public long? ID_Temeljnica { get; set; }
        public string Broj { get; set; }
        public DateTime? Datum { get; set; }
        public Nullable<System.TimeSpan> Vrijeme { get; set; }
        public string TablicaNaziv { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public Nullable<bool> Odabir { get; set; }
        public string DatumGodina { get; set; }
        public string VrijemeUpisString { get; set; }
        public string DatumString { get; set; }
        public long ID_UgovorStanOtkupAneks { get; set; }
        public long? ID_ZapisUgovorStanOtkupAneks { get; set; }
        public long? ID_UgovorStanOtkup { get; set; }
        public int BrojUgovor { get; set; }
        public int BrojAneks { get; set; }
        public int BrojStorno { get; set; }
        public long ID_UgovorStanOtkupKupac { get; set; }
        public long ID_Kupac { get; set; }
        public string Oznaka { get; set; }
        public string KupacNaziv { get; set; }
        public string JMBG { get; set; }
        public string Ulica { get; set; }
        public string KucniBroj { get; set; }
        public string KucniBrojDodatak { get; set; }
        public string OIB { get; set; }
        public string Posta { get; set; }
        public long ID_Osoba { get; set; }
        public long? OsobaID_Subjekt { get; set; }
        public string OsobaOznaka { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public long? KupacID_Subjekt { get; set; }
    }
}
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
    
    public partial class Izvod2012AStOtkup
    {
    
        public long ID_IzvodSt { get; set; }
        public long? ID_Izvod { get; set; }
        public Nullable<decimal> IznosDuguje { get; set; }
        public Nullable<decimal> IznosPotrazuje { get; set; }
        public Nullable<decimal> IznosDugujeValuta { get; set; }
        public Nullable<decimal> IznosPotrazujeValuta { get; set; }
        public long? ID_Subjekt { get; set; }
        public long? ID_Izvod2012ASt { get; set; }
        public long? Izvod2012AStID_IzvodSt { get; set; }
        public int? IDIzvod2012ATransakcijaVr { get; set; }
        public string Racun { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Sjediste { get; set; }
        public DateTime? DatumValuta { get; set; }
        public DateTime? DatumIzvrsenje { get; set; }
        public string IDValuta { get; set; }
        public Nullable<decimal> Tecaj { get; set; }
        public Nullable<decimal> IznosValuta { get; set; }
        public Nullable<decimal> Iznos { get; set; }
        public string PlatiteljPozivNaBroj { get; set; }
        public string PrimateljPozivNaBroj { get; set; }
        public int? IDHUBNamjena2013A { get; set; }
        public string OpisPlacanje { get; set; }
        public string IdentifikatorTransakcijeFINA { get; set; }
        public string IdentifikatorTransakcije { get; set; }
        public string Izvod2012ATransakcijaVrNaziv { get; set; }
        public string HUBNamjena2013AOznaka { get; set; }
        public string HUBNamjena2013ANaziv { get; set; }
        public string HUBNamjena2013ANazivKr { get; set; }
    }
}

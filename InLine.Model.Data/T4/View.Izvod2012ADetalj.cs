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
    
    public partial class Izvod2012ADetalj
    {
    
        public long ID_Izvod2012A { get; set; }
        public long? ID_Izvod { get; set; }
        public string BankaVBDI { get; set; }
        public string BankaNaziv { get; set; }
        public string BankaOIB { get; set; }
        public int? IzvadakVr { get; set; }
        public DateTime? DatumObrada { get; set; }
        public string BankaBIC { get; set; }
        public string Racun { get; set; }
        public string IDValuta { get; set; }
        public string Naziv { get; set; }
        public string Sjediste { get; set; }
        public string MaticniBroj { get; set; }
        public string OIB { get; set; }
        public int? RedniBrojIzvadak { get; set; }
        public int? PodbrojIzvadak { get; set; }
        public DateTime? DatumIzvadak { get; set; }
        public int? RedniBrojGrupa { get; set; }
        public int? VrstaIzvadak { get; set; }
        public long? ID_Zapis { get; set; }
        public int IDIzvodVerzija { get; set; }
        public Nullable<decimal> IznosDuguje { get; set; }
        public Nullable<decimal> IznosPotrazuje { get; set; }
        public Nullable<decimal> Saldostaro { get; set; }
        public Nullable<decimal> SaldoNovo { get; set; }
        public long? ID_SubjektRacun { get; set; }
    }
}

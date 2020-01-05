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
    
    public partial class UgovorStanOtkupObrokUplataDetalj
    {
    
        public long ID_UgovorStanOtkupObrokUplata { get; set; }
        public long? ID_UgovorStanOtkupObrok { get; set; }
        public DateTime? Datum { get; set; }
        public Nullable<decimal> IznosZateznaKamataUplata { get; set; }
        public Nullable<decimal> IznosValuta { get; set; }
        public Nullable<decimal> IznosValutaUgovor { get; set; }
        public Nullable<decimal> IznosZateznaKamataPrije { get; set; }
        public Nullable<decimal> IznosTecajnaRazlika { get; set; }
        public Nullable<decimal> IznosKredit { get; set; }
        public Nullable<decimal> IznosKamata { get; set; }
        public Nullable<decimal> IznosKreditRevalorizacija { get; set; }
        public Nullable<decimal> IznosKamataRevalorizacija { get; set; }
        public Nullable<decimal> IznosKreditMoratorij { get; set; }
        public Nullable<decimal> IznosKamataMoratorij { get; set; }
        public Nullable<decimal> IznosKreditMoratorijRevalorizacija { get; set; }
        public Nullable<decimal> IznosKamataMoratorijRevalorizacija { get; set; }
        public Nullable<decimal> IznosJednokratno { get; set; }
        public Nullable<decimal> IznosUcesce { get; set; }
        public Nullable<decimal> IznosPreplata { get; set; }
        public string IDValuta { get; set; }
        public int? TemeljnicaGodina { get; set; }
        public int? TemeljnicaVrsta { get; set; }
        public int? DokumentGrupa { get; set; }
        public int? TemeljnicaBroj { get; set; }
        public int? DokumentVrsta { get; set; }
        public Nullable<decimal> OsnovicaZateznaKamata { get; set; }
        public DateTime? DatumZateznaKamata { get; set; }
        public Nullable<decimal> IznosZateznaKamata { get; set; }
        public Nullable<decimal> IznosObrokDugOstatak { get; set; }
        public Nullable<decimal> IznosZateznaKamataDugOstatak { get; set; }
        public int? BrojUgovor { get; set; }
        public int? BrojAneks { get; set; }
        public int? BrojStorno { get; set; }
        public int? BrojObrok { get; set; }
        public long? ID_UgovorStanOtkupObrokZateznaKamata { get; set; }
        public int? BrojObrokZateznaKamata { get; set; }
        public int? BrojPreplata { get; set; }
        public long? ID_Racun { get; set; }
        public long? ID_PlacanjeVr { get; set; }
        public long? ID_Temeljnica { get; set; }
        public DateTime? DatumInsert { get; set; }
        public string OsobaInsert { get; set; }
        public DateTime? DatumUpdate { get; set; }
        public string OsobaUpdate { get; set; }
        public long? ID_OsobaInsert { get; set; }
        public long? ID_OsobaUpdate { get; set; }
        public Nullable<bool> NeZateznaKamata { get; set; }
        public string PlacanjeVrOznaka { get; set; }
        public string PlacanjeVrNaziv { get; set; }
        public int? GodinaUplata { get; set; }
    }
}
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
    
    public partial class UgovorStanOtkupKupacNositelj
    {
    
        public long ID_Kupac { get; set; }
        public string Naziv { get; set; }
        public string UlicaKupac { get; set; }
        public long ID_UgovorStanOtkup { get; set; }
        public string UlicaStan { get; set; }
        public int BrojUgovor { get; set; }
        public DateTime? Datum { get; set; }
        public long? ID_UgovorStanOtkupKupac { get; set; }
        public string Napomena { get; set; }
        public string JMBG { get; set; }
        public string OIB { get; set; }
        public Nullable<bool> Nositelj { get; set; }
        public Nullable<byte> KontrolniBroj { get; set; }
        public string PostanskiBroj { get; set; }
    }
}
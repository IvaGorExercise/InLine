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
    
    public partial class UgovorStanOtkupKupac
    {
    
        public long ID_Kupac { get; set; }
        public string Naziv { get; set; }
        public long ID_UgovorStanOtkup { get; set; }
        public int BrojUgovor { get; set; }
        public long? ID_UgovorStanOtkupKupac { get; set; }
        public string JMBG { get; set; }
        public string OIB { get; set; }
        public Nullable<bool> Nositelj { get; set; }
        public string Ulica { get; set; }
        public string KucniBroj { get; set; }
        public string KucniBrojDodatak { get; set; }
        public string PostanskiBroj { get; set; }
    }
}

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
    
    public partial class UgovorStanOtkupNalog
    {
    
        public long? ID_UgovorStanOtkup { get; set; }
        public DateTime? DatumPlacanje { get; set; }
        public decimal Iznos { get; set; }
        public int GodinaNalog { get; set; }
        public int BrojNalog { get; set; }
        public int BrojUgovor { get; set; }
        public long ID_Nalog { get; set; }
    }
}
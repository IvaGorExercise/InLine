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
    
    public partial class Opomena
    {
    
        public long ID_Opomena { get; set; }
        public long? ID_Zapis { get; set; }
        public int BrojOpomena { get; set; }
        public DateTime? Datum { get; set; }
        public int? BrojNeplaceniObrokMin { get; set; }
        public DateTime? DatumDospijeceDo { get; set; }
        public DateTime? DatumDospijeceOd { get; set; }
        public DateTime? DatumInsert { get; set; }
        public DateTime? DatumUpdate { get; set; }
        public long? ID_OsobaInsert { get; set; }
        public long? ID_OsobaUpdate { get; set; }
        public Nullable<decimal> OpomenaIznosMin { get; set; }
        public string OsobaInsert { get; set; }
        public string OsobaUpdate { get; set; }
    }
}

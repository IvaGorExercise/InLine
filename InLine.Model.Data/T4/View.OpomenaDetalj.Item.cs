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
    
    public partial class OpomenaDetaljItem 
    {
    
    	public OpomenaDetaljItem() {}
    	public OpomenaDetaljItem(int? brojOpomena, long? id_Opomena)
    	{
    		BrojOpomena = brojOpomena;
    		ID_Opomena = id_Opomena;
    	}
    
        public DateTime? Datum { get; set; }
        public int? BrojOpomena { get; set; }
        public long? ID_Opomena { get; set; }
        public DateTime? DatumDospijeceOd { get; set; }
        public DateTime? DatumDospijeceDo { get; set; }
        public long? ID_Zapis { get; set; }
        public decimal? OpomenaIznosMin { get; set; }
        public int? BrojNeplaceniObrokMin { get; set; }
        public DateTime? DatumInsert { get; set; }
        public string OsobaInsert { get; set; }
        public DateTime? DatumUpdate { get; set; }
        public string OsobaUpdate { get; set; }
        public long? ID_OsobaInsert { get; set; }
        public long? ID_OsobaUpdate { get; set; }
    
    	public OpomenaDetaljItem(Model.Data.View.OpomenaDetalj item)
    	{
    	    this.Datum = item.Datum;
        this.BrojOpomena = item.BrojOpomena;
        this.ID_Opomena = item.ID_Opomena;
        this.DatumDospijeceOd = item.DatumDospijeceOd;
        this.DatumDospijeceDo = item.DatumDospijeceDo;
        this.ID_Zapis = item.ID_Zapis;
        this.OpomenaIznosMin = item.OpomenaIznosMin;
        this.BrojNeplaceniObrokMin = item.BrojNeplaceniObrokMin;
        this.DatumInsert = item.DatumInsert;
        this.OsobaInsert = item.OsobaInsert;
        this.DatumUpdate = item.DatumUpdate;
        this.OsobaUpdate = item.OsobaUpdate;
        this.ID_OsobaInsert = item.ID_OsobaInsert;
        this.ID_OsobaUpdate = item.ID_OsobaUpdate;
    	}
    
    	public OpomenaDetaljItem(dynamic item)
    	{
    	    this.Datum = item.Datum;
        this.BrojOpomena = item.BrojOpomena;
        this.ID_Opomena = item.ID_Opomena;
        this.DatumDospijeceOd = item.DatumDospijeceOd;
        this.DatumDospijeceDo = item.DatumDospijeceDo;
        this.ID_Zapis = item.ID_Zapis;
        this.OpomenaIznosMin = item.OpomenaIznosMin;
        this.BrojNeplaceniObrokMin = item.BrojNeplaceniObrokMin;
        this.DatumInsert = item.DatumInsert;
        this.OsobaInsert = item.OsobaInsert;
        this.DatumUpdate = item.DatumUpdate;
        this.OsobaUpdate = item.OsobaUpdate;
        this.ID_OsobaInsert = item.ID_OsobaInsert;
        this.ID_OsobaUpdate = item.ID_OsobaUpdate;
    	}
    }
}

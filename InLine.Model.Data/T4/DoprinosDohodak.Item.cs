//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoprinosDohodakItem 
    {
    
    	public DoprinosDohodakItem() {}
    	public DoprinosDohodakItem(long? id_DoprinosDohodak)
    	{
    		ID_DoprinosDohodak = id_DoprinosDohodak;
    	}
    
        public long? ID
    	{
    		get { return this.ID_DoprinosDohodak; }
    		set { this.ID_DoprinosDohodak = value; }
    	}
        public long? ID_DoprinosDohodak { get; set; }
        public long? ID_DoprinosDohodakVr { get; set; }
        public long? ID_Davanje { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public decimal? Stopa { get; set; }
        public bool? IzBruto { get; set; }
        public int? IDMirovinskiStup { get; set; }
        public int? IDPoticanjeZaposljavanja { get; set; }
        public bool? PrvoZaposlenje { get; set; }
    
    	public DoprinosDohodakItem(Model.Data.DoprinosDohodak item)
    	{
    	    this.ID_DoprinosDohodak = item.ID_DoprinosDohodak;
        this.ID_DoprinosDohodakVr = item.ID_DoprinosDohodakVr;
        this.ID_Davanje = item.ID_Davanje;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.Stopa = item.Stopa;
        this.IzBruto = item.IzBruto;
        this.IDMirovinskiStup = item.IDMirovinskiStup;
        this.IDPoticanjeZaposljavanja = item.IDPoticanjeZaposljavanja;
        this.PrvoZaposlenje = item.PrvoZaposlenje;
    	}
    
    	public DoprinosDohodakItem(dynamic item)
    	{
    	    this.ID_DoprinosDohodak = item.ID_DoprinosDohodak;
        this.ID_DoprinosDohodakVr = item.ID_DoprinosDohodakVr;
        this.ID_Davanje = item.ID_Davanje;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.Stopa = item.Stopa;
        this.IzBruto = item.IzBruto;
        this.IDMirovinskiStup = item.IDMirovinskiStup;
        this.IDPoticanjeZaposljavanja = item.IDPoticanjeZaposljavanja;
        this.PrvoZaposlenje = item.PrvoZaposlenje;
    	}
    }
}
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
    
    public partial class ZupanijaGrTipItem 
    {
    
    	public ZupanijaGrTipItem() {}
    	public ZupanijaGrTipItem(long? id_ZupanijaGrTip)
    	{
    		ID_ZupanijaGrTip = id_ZupanijaGrTip;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ZupanijaGrTip; }
    		set { this.ID_ZupanijaGrTip = value; }
    	}
        public long? ID_ZupanijaGrTip { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
        public string StsZupanijaGrTip { get; set; }
    
    	public ZupanijaGrTipItem(Model.Data.ZupanijaGrTip item)
    	{
    	    this.ID_ZupanijaGrTip = item.ID_ZupanijaGrTip;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
        this.StsZupanijaGrTip = item.StsZupanijaGrTip;
    	}
    
    	public ZupanijaGrTipItem(dynamic item)
    	{
    	    this.ID_ZupanijaGrTip = item.ID_ZupanijaGrTip;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
        this.StsZupanijaGrTip = item.StsZupanijaGrTip;
    	}
    }
}

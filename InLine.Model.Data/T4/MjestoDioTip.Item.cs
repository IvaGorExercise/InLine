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
    
    public partial class MjestoDioTipItem 
    {
    
    	public MjestoDioTipItem() {}
    	public MjestoDioTipItem(long? id_MjestoDioTip)
    	{
    		ID_MjestoDioTip = id_MjestoDioTip;
    	}
    
        public long? ID
    	{
    		get { return this.ID_MjestoDioTip; }
    		set { this.ID_MjestoDioTip = value; }
    	}
        public long? ID_MjestoDioTip { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
    
    	public MjestoDioTipItem(Model.Data.MjestoDioTip item)
    	{
    	    this.ID_MjestoDioTip = item.ID_MjestoDioTip;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    
    	public MjestoDioTipItem(dynamic item)
    	{
    	    this.ID_MjestoDioTip = item.ID_MjestoDioTip;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    }
}

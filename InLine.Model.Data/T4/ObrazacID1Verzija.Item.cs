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
    
    public partial class ObrazacID1VerzijaItem 
    {
    
    	public ObrazacID1VerzijaItem() {}
    	public ObrazacID1VerzijaItem(int? idObrazacID1Verzija)
    	{
    		IDObrazacID1Verzija = idObrazacID1Verzija;
    	}
    
        public int? IDObrazacID1Verzija { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
        public string OpisHTML { get; set; }
        public string NapomenaHTML { get; set; }
    
    	public ObrazacID1VerzijaItem(Model.Data.ObrazacID1Verzija item)
    	{
    	    this.IDObrazacID1Verzija = item.IDObrazacID1Verzija;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.Opis = item.Opis;
        this.Napomena = item.Napomena;
        this.OpisHTML = item.OpisHTML;
        this.NapomenaHTML = item.NapomenaHTML;
    	}
    
    	public ObrazacID1VerzijaItem(dynamic item)
    	{
    	    this.IDObrazacID1Verzija = item.IDObrazacID1Verzija;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.Opis = item.Opis;
        this.Napomena = item.Napomena;
        this.OpisHTML = item.OpisHTML;
        this.NapomenaHTML = item.NapomenaHTML;
    	}
    }
}
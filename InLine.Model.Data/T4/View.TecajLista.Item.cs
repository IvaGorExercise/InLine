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
    
    public partial class TecajListaItem 
    {
    
    	public TecajListaItem() {}
    	public TecajListaItem(long? id_TecajLista, long? id_Banka, DateTime? datum, int? redniBroj)
    	{
    		ID_TecajLista = id_TecajLista;
    		ID_Banka = id_Banka;
    		Datum = datum;
    		RedniBroj = redniBroj;
    	}
    
        public long? ID_TecajLista { get; set; }
        public long? ID_Banka { get; set; }
        public DateTime? Datum { get; set; }
        public int? RedniBroj { get; set; }
        public int? Godina { get; set; }
        public int? GodinaRedniBroj { get; set; }
    
    	public TecajListaItem(Model.Data.View.TecajLista item)
    	{
    	    this.ID_TecajLista = item.ID_TecajLista;
        this.ID_Banka = item.ID_Banka;
        this.Datum = item.Datum;
        this.RedniBroj = item.RedniBroj;
        this.Godina = item.Godina;
        this.GodinaRedniBroj = item.GodinaRedniBroj;
    	}
    
    	public TecajListaItem(dynamic item)
    	{
    	    this.ID_TecajLista = item.ID_TecajLista;
        this.ID_Banka = item.ID_Banka;
        this.Datum = item.Datum;
        this.RedniBroj = item.RedniBroj;
        this.Godina = item.Godina;
        this.GodinaRedniBroj = item.GodinaRedniBroj;
    	}
    }
}

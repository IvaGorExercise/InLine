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
    
    public partial class PoslovniSubjektItem 
    {
    
    	public PoslovniSubjektItem() {}
    	public PoslovniSubjektItem(long? id_PoslovniSubjekt, long? id_Subjekt, long? idSubjekt, string naziv, string oznaka)
    	{
    		ID_PoslovniSubjekt = id_PoslovniSubjekt;
    		ID_Subjekt = id_Subjekt;
    		IDSubjekt = idSubjekt;
    		Naziv = naziv;
    		Oznaka = oznaka;
    	}
    
        public long? ID_PoslovniSubjekt { get; set; }
        public long? ID_Subjekt { get; set; }
        public long? IDSubjekt { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
    
    	public PoslovniSubjektItem(Model.Data.View.PoslovniSubjekt item)
    	{
    	    this.ID_PoslovniSubjekt = item.ID_PoslovniSubjekt;
        this.ID_Subjekt = item.ID_Subjekt;
        this.IDSubjekt = item.IDSubjekt;
        this.Naziv = item.Naziv;
        this.Oznaka = item.Oznaka;
    	}
    
    	public PoslovniSubjektItem(dynamic item)
    	{
    	    this.ID_PoslovniSubjekt = item.ID_PoslovniSubjekt;
        this.ID_Subjekt = item.ID_Subjekt;
        this.IDSubjekt = item.IDSubjekt;
        this.Naziv = item.Naziv;
        this.Oznaka = item.Oznaka;
    	}
    }
}

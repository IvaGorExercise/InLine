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
    
    public partial class SubjektVrTablicaItem 
    {
    
    	public SubjektVrTablicaItem() {}
    	public SubjektVrTablicaItem(int? idSubjektVr)
    	{
    		IDSubjektVr = idSubjektVr;
    	}
    
        public int? IDSubjektVr { get; set; }
        public int? IDSubjektTablica { get; set; }
        public bool? Odabir { get; set; }
    
    	public SubjektVrTablicaItem(Model.Data.SubjektVrTablica item)
    	{
    	    this.IDSubjektVr = item.IDSubjektVr;
        this.IDSubjektTablica = item.IDSubjektTablica;
        this.Odabir = item.Odabir;
    	}
    
    	public SubjektVrTablicaItem(dynamic item)
    	{
    	    this.IDSubjektVr = item.IDSubjektVr;
        this.IDSubjektTablica = item.IDSubjektTablica;
        this.Odabir = item.Odabir;
    	}
    }
}

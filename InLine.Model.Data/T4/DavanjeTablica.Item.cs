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
    
    public partial class DavanjeTablicaItem 
    {
    
    	public DavanjeTablicaItem() {}
    	public DavanjeTablicaItem(int? idDavanjeTablica)
    	{
    		IDDavanjeTablica = idDavanjeTablica;
    	}
    
        public int? IDDavanjeTablica { get; set; }
        public string TablicaShema { get; set; }
        public string TablicaNaziv { get; set; }
    
    	public DavanjeTablicaItem(Model.Data.DavanjeTablica item)
    	{
    	    this.IDDavanjeTablica = item.IDDavanjeTablica;
        this.TablicaShema = item.TablicaShema;
        this.TablicaNaziv = item.TablicaNaziv;
    	}
    
    	public DavanjeTablicaItem(dynamic item)
    	{
    	    this.IDDavanjeTablica = item.IDDavanjeTablica;
        this.TablicaShema = item.TablicaShema;
        this.TablicaNaziv = item.TablicaNaziv;
    	}
    }
}

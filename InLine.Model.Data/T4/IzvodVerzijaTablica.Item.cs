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
    
    public partial class IzvodVerzijaTablicaItem 
    {
    
    	public IzvodVerzijaTablicaItem() {}
    	public IzvodVerzijaTablicaItem(int? idIzvodVerzija, int? idIzvodVerzijaTablica)
    	{
    		IDIzvodVerzija = idIzvodVerzija;
    		IDIzvodVerzijaTablica = idIzvodVerzijaTablica;
    	}
    
        public int? IDIzvodVerzija { get; set; }
        public int? IDIzvodVerzijaTablica { get; set; }
        public string TablicaShema { get; set; }
        public string TablicaNaziv { get; set; }
    
    	public IzvodVerzijaTablicaItem(Model.Data.IzvodVerzijaTablica item)
    	{
    	    this.IDIzvodVerzija = item.IDIzvodVerzija;
        this.IDIzvodVerzijaTablica = item.IDIzvodVerzijaTablica;
        this.TablicaShema = item.TablicaShema;
        this.TablicaNaziv = item.TablicaNaziv;
    	}
    
    	public IzvodVerzijaTablicaItem(dynamic item)
    	{
    	    this.IDIzvodVerzija = item.IDIzvodVerzija;
        this.IDIzvodVerzijaTablica = item.IDIzvodVerzijaTablica;
        this.TablicaShema = item.TablicaShema;
        this.TablicaNaziv = item.TablicaNaziv;
    	}
    }
}

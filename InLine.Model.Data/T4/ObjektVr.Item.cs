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
    
    public partial class ObjektVrItem 
    {
    
    	public ObjektVrItem() {}
    	public ObjektVrItem(int? idObjektVr)
    	{
    		IDObjektVr = idObjektVr;
    	}
    
        public int? IDObjektVr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public ObjektVrItem(Model.Data.ObjektVr item)
    	{
    	    this.IDObjektVr = item.IDObjektVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public ObjektVrItem(dynamic item)
    	{
    	    this.IDObjektVr = item.IDObjektVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}

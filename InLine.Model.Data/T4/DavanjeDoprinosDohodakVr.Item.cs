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
    
    public partial class DavanjeDoprinosDohodakVrItem 
    {
    
    	public DavanjeDoprinosDohodakVrItem() {}
    	public DavanjeDoprinosDohodakVrItem(int? idDavanjeDoprinosDohodakVr)
    	{
    		IDDavanjeDoprinosDohodakVr = idDavanjeDoprinosDohodakVr;
    	}
    
        public int? IDDavanjeDoprinosDohodakVr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public DavanjeDoprinosDohodakVrItem(Model.Data.DavanjeDoprinosDohodakVr item)
    	{
    	    this.IDDavanjeDoprinosDohodakVr = item.IDDavanjeDoprinosDohodakVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public DavanjeDoprinosDohodakVrItem(dynamic item)
    	{
    	    this.IDDavanjeDoprinosDohodakVr = item.IDDavanjeDoprinosDohodakVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}

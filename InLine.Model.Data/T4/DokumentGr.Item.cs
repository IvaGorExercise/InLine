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
    
    public partial class DokumentGrItem 
    {
    
    	public DokumentGrItem() {}
    	public DokumentGrItem(int? idDokumentGr)
    	{
    		IDDokumentGr = idDokumentGr;
    	}
    
        public int? IDDokumentGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
    
    	public DokumentGrItem(Model.Data.DokumentGr item)
    	{
    	    this.IDDokumentGr = item.IDDokumentGr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    
    	public DokumentGrItem(dynamic item)
    	{
    	    this.IDDokumentGr = item.IDDokumentGr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    }
}
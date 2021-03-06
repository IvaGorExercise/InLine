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
    
    public partial class PorezDohodakVrItem 
    {
    
    	public PorezDohodakVrItem() {}
    	public PorezDohodakVrItem(long? id_PorezDohodakVr)
    	{
    		ID_PorezDohodakVr = id_PorezDohodakVr;
    	}
    
        public long? ID
    	{
    		get { return this.ID_PorezDohodakVr; }
    		set { this.ID_PorezDohodakVr = value; }
    	}
        public long? ID_PorezDohodakVr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public decimal? OsobniOdbitak { get; set; }
        public int? NNGodina { get; set; }
        public int? NNBroj { get; set; }
        public int? NNClanak { get; set; }
        public DateTime? NNDatum { get; set; }
    
    	public PorezDohodakVrItem(Model.Data.PorezDohodakVr item)
    	{
    	    this.ID_PorezDohodakVr = item.ID_PorezDohodakVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.OsobniOdbitak = item.OsobniOdbitak;
        this.NNGodina = item.NNGodina;
        this.NNBroj = item.NNBroj;
        this.NNClanak = item.NNClanak;
        this.NNDatum = item.NNDatum;
    	}
    
    	public PorezDohodakVrItem(dynamic item)
    	{
    	    this.ID_PorezDohodakVr = item.ID_PorezDohodakVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.OsobniOdbitak = item.OsobniOdbitak;
        this.NNGodina = item.NNGodina;
        this.NNBroj = item.NNBroj;
        this.NNClanak = item.NNClanak;
        this.NNDatum = item.NNDatum;
    	}
    }
}

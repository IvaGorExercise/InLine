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
    
    public partial class MjestoGrMjestoDatumItem 
    {
    
    	public MjestoGrMjestoDatumItem() {}
    	public MjestoGrMjestoDatumItem(long? id_MjestoGrMjestoDatum)
    	{
    		ID_MjestoGrMjestoDatum = id_MjestoGrMjestoDatum;
    	}
    
        public long? ID
    	{
    		get { return this.ID_MjestoGrMjestoDatum; }
    		set { this.ID_MjestoGrMjestoDatum = value; }
    	}
        public long? ID_MjestoGrMjestoDatum { get; set; }
        public long? ID_MjestoGrMjesto { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
    
    	public MjestoGrMjestoDatumItem(Model.Data.MjestoGrMjestoDatum item)
    	{
    	    this.ID_MjestoGrMjestoDatum = item.ID_MjestoGrMjestoDatum;
        this.ID_MjestoGrMjesto = item.ID_MjestoGrMjesto;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    
    	public MjestoGrMjestoDatumItem(dynamic item)
    	{
    	    this.ID_MjestoGrMjestoDatum = item.ID_MjestoGrMjestoDatum;
        this.ID_MjestoGrMjesto = item.ID_MjestoGrMjesto;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    }
}

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
    
    public partial class ObveznicaJavnogDugaItem 
    {
    
    	public ObveznicaJavnogDugaItem() {}
    	public ObveznicaJavnogDugaItem(long? id_ObveznicaJavnogDuga)
    	{
    		ID_ObveznicaJavnogDuga = id_ObveznicaJavnogDuga;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ObveznicaJavnogDuga; }
    		set { this.ID_ObveznicaJavnogDuga = value; }
    	}
        public long? ID_ObveznicaJavnogDuga { get; set; }
        public string Broj { get; set; }
        public DateTime? Datum { get; set; }
        public int? DokumentVrsta { get; set; }
        public int? DokumentGrupa { get; set; }
        public long? ID_DokumentVr { get; set; }
        public int? TemeljnicaGodina { get; set; }
        public int? TemeljnicaVrsta { get; set; }
        public int? TemeljnicaBroj { get; set; }
        public long? ID_Temeljnica { get; set; }
    
    	public ObveznicaJavnogDugaItem(Model.Data.ObveznicaJavnogDuga item)
    	{
    	    this.ID_ObveznicaJavnogDuga = item.ID_ObveznicaJavnogDuga;
        this.Broj = item.Broj;
        this.Datum = item.Datum;
        this.DokumentVrsta = item.DokumentVrsta;
        this.DokumentGrupa = item.DokumentGrupa;
        this.ID_DokumentVr = item.ID_DokumentVr;
        this.TemeljnicaGodina = item.TemeljnicaGodina;
        this.TemeljnicaVrsta = item.TemeljnicaVrsta;
        this.TemeljnicaBroj = item.TemeljnicaBroj;
        this.ID_Temeljnica = item.ID_Temeljnica;
    	}
    
    	public ObveznicaJavnogDugaItem(dynamic item)
    	{
    	    this.ID_ObveznicaJavnogDuga = item.ID_ObveznicaJavnogDuga;
        this.Broj = item.Broj;
        this.Datum = item.Datum;
        this.DokumentVrsta = item.DokumentVrsta;
        this.DokumentGrupa = item.DokumentGrupa;
        this.ID_DokumentVr = item.ID_DokumentVr;
        this.TemeljnicaGodina = item.TemeljnicaGodina;
        this.TemeljnicaVrsta = item.TemeljnicaVrsta;
        this.TemeljnicaBroj = item.TemeljnicaBroj;
        this.ID_Temeljnica = item.ID_Temeljnica;
    	}
    }
}
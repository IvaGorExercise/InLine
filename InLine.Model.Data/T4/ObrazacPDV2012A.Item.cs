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
    
    public partial class ObrazacPDV2012AItem 
    {
    
    	public ObrazacPDV2012AItem() {}
    	public ObrazacPDV2012AItem(long? id_ObrazacPDV2012A)
    	{
    		ID_ObrazacPDV2012A = id_ObrazacPDV2012A;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ObrazacPDV2012A; }
    		set { this.ID_ObrazacPDV2012A = value; }
    	}
        public long? ID_ObrazacPDV2012A { get; set; }
        public long? ID_ObrazacPDV { get; set; }
        public string PorezniObveznikNaziv { get; set; }
        public string PorezniObveznikAdresa { get; set; }
        public decimal? VrijednostNeoporezivo { get; set; }
        public decimal? VrijednostOslobodenoIzvoz { get; set; }
        public decimal? VrijednostOslobodenoIsporuka { get; set; }
        public decimal? VrijednostOslobodenoTuzemstvo { get; set; }
        public decimal? VrijednostOslobodenoOstalo { get; set; }
        public decimal? VrijednostPorez0 { get; set; }
        public decimal? VrijednostPorez10 { get; set; }
        public decimal? IznosPorez10 { get; set; }
        public decimal? VrijednostPorez22 { get; set; }
        public decimal? IznosPorez22 { get; set; }
        public decimal? VrijednostPorez23 { get; set; }
        public decimal? IznosPorez23 { get; set; }
        public decimal? VrijednostPorez25 { get; set; }
        public decimal? IznosPorez25 { get; set; }
        public decimal? VrijednostPretporez10 { get; set; }
        public decimal? IznosPretporez10 { get; set; }
        public decimal? VrijednostPretporez22 { get; set; }
        public decimal? IznosPretporez22 { get; set; }
        public decimal? VrijednostPretporez23 { get; set; }
        public decimal? IznosPretporez23 { get; set; }
        public decimal? VrijednostPretporez25 { get; set; }
        public decimal? IznosPretporez25 { get; set; }
        public decimal? VrijednostPretporezUvoz { get; set; }
        public decimal? IznosPretporezUvoz { get; set; }
        public decimal? VrijednostPretporez10OdbitakNe { get; set; }
        public decimal? VrijednostPretporez10OdbitakDa { get; set; }
        public decimal? IznosPretporez10ObitakDa { get; set; }
        public decimal? VrijednostPretporez22OdbitakNe { get; set; }
        public decimal? VrijednostPretporez22OdbitakDa { get; set; }
        public decimal? IznosPretporez22ObitakDa { get; set; }
        public decimal? VrijednostPretporez23OdbitakNe { get; set; }
        public decimal? VrijednostPretporez23OdbitakDa { get; set; }
        public decimal? IznosPretporez23ObitakDa { get; set; }
        public decimal? VrijednostPretporez25OdbitakNe { get; set; }
        public decimal? VrijednostPretporez25OdbitakDa { get; set; }
        public decimal? IznosPretporez25ObitakDa { get; set; }
        public decimal? IznosPretporezIspravak { get; set; }
    
    	public ObrazacPDV2012AItem(Model.Data.ObrazacPDV2012A item)
    	{
    	    this.ID_ObrazacPDV2012A = item.ID_ObrazacPDV2012A;
        this.ID_ObrazacPDV = item.ID_ObrazacPDV;
        this.PorezniObveznikNaziv = item.PorezniObveznikNaziv;
        this.PorezniObveznikAdresa = item.PorezniObveznikAdresa;
        this.VrijednostNeoporezivo = item.VrijednostNeoporezivo;
        this.VrijednostOslobodenoIzvoz = item.VrijednostOslobodenoIzvoz;
        this.VrijednostOslobodenoIsporuka = item.VrijednostOslobodenoIsporuka;
        this.VrijednostOslobodenoTuzemstvo = item.VrijednostOslobodenoTuzemstvo;
        this.VrijednostOslobodenoOstalo = item.VrijednostOslobodenoOstalo;
        this.VrijednostPorez0 = item.VrijednostPorez0;
        this.VrijednostPorez10 = item.VrijednostPorez10;
        this.IznosPorez10 = item.IznosPorez10;
        this.VrijednostPorez22 = item.VrijednostPorez22;
        this.IznosPorez22 = item.IznosPorez22;
        this.VrijednostPorez23 = item.VrijednostPorez23;
        this.IznosPorez23 = item.IznosPorez23;
        this.VrijednostPorez25 = item.VrijednostPorez25;
        this.IznosPorez25 = item.IznosPorez25;
        this.VrijednostPretporez10 = item.VrijednostPretporez10;
        this.IznosPretporez10 = item.IznosPretporez10;
        this.VrijednostPretporez22 = item.VrijednostPretporez22;
        this.IznosPretporez22 = item.IznosPretporez22;
        this.VrijednostPretporez23 = item.VrijednostPretporez23;
        this.IznosPretporez23 = item.IznosPretporez23;
        this.VrijednostPretporez25 = item.VrijednostPretporez25;
        this.IznosPretporez25 = item.IznosPretporez25;
        this.VrijednostPretporezUvoz = item.VrijednostPretporezUvoz;
        this.IznosPretporezUvoz = item.IznosPretporezUvoz;
        this.VrijednostPretporez10OdbitakNe = item.VrijednostPretporez10OdbitakNe;
        this.VrijednostPretporez10OdbitakDa = item.VrijednostPretporez10OdbitakDa;
        this.IznosPretporez10ObitakDa = item.IznosPretporez10ObitakDa;
        this.VrijednostPretporez22OdbitakNe = item.VrijednostPretporez22OdbitakNe;
        this.VrijednostPretporez22OdbitakDa = item.VrijednostPretporez22OdbitakDa;
        this.IznosPretporez22ObitakDa = item.IznosPretporez22ObitakDa;
        this.VrijednostPretporez23OdbitakNe = item.VrijednostPretporez23OdbitakNe;
        this.VrijednostPretporez23OdbitakDa = item.VrijednostPretporez23OdbitakDa;
        this.IznosPretporez23ObitakDa = item.IznosPretporez23ObitakDa;
        this.VrijednostPretporez25OdbitakNe = item.VrijednostPretporez25OdbitakNe;
        this.VrijednostPretporez25OdbitakDa = item.VrijednostPretporez25OdbitakDa;
        this.IznosPretporez25ObitakDa = item.IznosPretporez25ObitakDa;
        this.IznosPretporezIspravak = item.IznosPretporezIspravak;
    	}
    
    	public ObrazacPDV2012AItem(dynamic item)
    	{
    	    this.ID_ObrazacPDV2012A = item.ID_ObrazacPDV2012A;
        this.ID_ObrazacPDV = item.ID_ObrazacPDV;
        this.PorezniObveznikNaziv = item.PorezniObveznikNaziv;
        this.PorezniObveznikAdresa = item.PorezniObveznikAdresa;
        this.VrijednostNeoporezivo = item.VrijednostNeoporezivo;
        this.VrijednostOslobodenoIzvoz = item.VrijednostOslobodenoIzvoz;
        this.VrijednostOslobodenoIsporuka = item.VrijednostOslobodenoIsporuka;
        this.VrijednostOslobodenoTuzemstvo = item.VrijednostOslobodenoTuzemstvo;
        this.VrijednostOslobodenoOstalo = item.VrijednostOslobodenoOstalo;
        this.VrijednostPorez0 = item.VrijednostPorez0;
        this.VrijednostPorez10 = item.VrijednostPorez10;
        this.IznosPorez10 = item.IznosPorez10;
        this.VrijednostPorez22 = item.VrijednostPorez22;
        this.IznosPorez22 = item.IznosPorez22;
        this.VrijednostPorez23 = item.VrijednostPorez23;
        this.IznosPorez23 = item.IznosPorez23;
        this.VrijednostPorez25 = item.VrijednostPorez25;
        this.IznosPorez25 = item.IznosPorez25;
        this.VrijednostPretporez10 = item.VrijednostPretporez10;
        this.IznosPretporez10 = item.IznosPretporez10;
        this.VrijednostPretporez22 = item.VrijednostPretporez22;
        this.IznosPretporez22 = item.IznosPretporez22;
        this.VrijednostPretporez23 = item.VrijednostPretporez23;
        this.IznosPretporez23 = item.IznosPretporez23;
        this.VrijednostPretporez25 = item.VrijednostPretporez25;
        this.IznosPretporez25 = item.IznosPretporez25;
        this.VrijednostPretporezUvoz = item.VrijednostPretporezUvoz;
        this.IznosPretporezUvoz = item.IznosPretporezUvoz;
        this.VrijednostPretporez10OdbitakNe = item.VrijednostPretporez10OdbitakNe;
        this.VrijednostPretporez10OdbitakDa = item.VrijednostPretporez10OdbitakDa;
        this.IznosPretporez10ObitakDa = item.IznosPretporez10ObitakDa;
        this.VrijednostPretporez22OdbitakNe = item.VrijednostPretporez22OdbitakNe;
        this.VrijednostPretporez22OdbitakDa = item.VrijednostPretporez22OdbitakDa;
        this.IznosPretporez22ObitakDa = item.IznosPretporez22ObitakDa;
        this.VrijednostPretporez23OdbitakNe = item.VrijednostPretporez23OdbitakNe;
        this.VrijednostPretporez23OdbitakDa = item.VrijednostPretporez23OdbitakDa;
        this.IznosPretporez23ObitakDa = item.IznosPretporez23ObitakDa;
        this.VrijednostPretporez25OdbitakNe = item.VrijednostPretporez25OdbitakNe;
        this.VrijednostPretporez25OdbitakDa = item.VrijednostPretporez25OdbitakDa;
        this.IznosPretporez25ObitakDa = item.IznosPretporez25ObitakDa;
        this.IznosPretporezIspravak = item.IznosPretporezIspravak;
    	}
    }
}

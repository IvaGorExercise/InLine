//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class TablicaPoljeGrTablicaPoljeItem : Model.Admin.TablicaPoljeGrTablicaPolje
    {
    
    	public TablicaPoljeGrTablicaPoljeItem() {}
    	public TablicaPoljeGrTablicaPoljeItem(long id_TablicaPoljeGrTablicaPolje)
    	{
    		ID_TablicaPoljeGrTablicaPolje = id_TablicaPoljeGrTablicaPolje;
    	}
        public long ID
    	{
    		get { return this.ID_TablicaPoljeGrTablicaPolje; }
    		set { this.ID_TablicaPoljeGrTablicaPolje = value; }
    	}
        public long ID_TablicaPoljeGrTablicaPolje { get; set; }
        public long ID_TablicaPoljeGr { get; set; }
        public bool TablicaKorisnik { get; set; }
        public string TablicaShema { get; set; }
        public string TablicaNaziv { get; set; }
        public string TablicaPoljeNaziv { get; set; }
        public long? ID_TablicaPoljeGrTablicaPoljeNad { get; set; }
    }
}

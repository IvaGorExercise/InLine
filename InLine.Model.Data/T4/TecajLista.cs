//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TecajLista
    {
    
        public TecajLista()
        {
    
            this.TecajListaSt = new HashSet<TecajListaSt>();
        }
    
        public long ID
    	{
    		get { return this.ID_TecajLista; }
    		set { this.ID_TecajLista = value; }
    	}
        public long ID_TecajLista { get; set; }
        public long ID_Banka { get; set; }
        public DateTime Datum { get; set; }
        public int RedniBroj { get; set; }
        public int? Godina { get; set; }
        public int? GodinaRedniBroj { get; set; }
    
        public virtual Banka Banka { get; set; }
        public virtual ICollection<TecajListaSt> TecajListaSt { get; set; }
    }
}
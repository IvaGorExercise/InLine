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
    
    public partial class PorezDohodakVr
    {
    
        public PorezDohodakVr()
        {
    
            this.PorezDohodak = new HashSet<PorezDohodak>();
        }
    
        public long ID
    	{
    		get { return this.ID_PorezDohodakVr; }
    		set { this.ID_PorezDohodakVr = value; }
    	}
        public long ID_PorezDohodakVr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public decimal OsobniOdbitak { get; set; }
        public int? NNGodina { get; set; }
        public int? NNBroj { get; set; }
        public int? NNClanak { get; set; }
        public DateTime? NNDatum { get; set; }
    
        public virtual ICollection<PorezDohodak> PorezDohodak { get; set; }
    }
}

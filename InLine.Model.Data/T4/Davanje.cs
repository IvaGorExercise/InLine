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
    
    public partial class Davanje
    {
    
        public Davanje()
        {
    
            this.DohodakDavanje = new HashSet<DohodakDavanje>();
            this.DohodakPrimateljDavanje = new HashSet<DohodakPrimateljDavanje>();
            this.DohodakPrimateljPrimitakDavanje = new HashSet<DohodakPrimateljPrimitakDavanje>();
            this.DoprinosDohodak = new HashSet<DoprinosDohodak>();
            this.PDV = new HashSet<PDV>();
            this.PorezDohodak = new HashSet<PorezDohodak>();
            this.PorezDohodakPrirez = new HashSet<PorezDohodakPrirez>();
            this.PosebanPorezDohodak = new HashSet<PosebanPorezDohodak>();
            this.RacunIzlazSt = new HashSet<RacunIzlazSt>();
            this.RacunUlazSt = new HashSet<RacunUlazSt>();
            this.TemeljnicaSt = new HashSet<TemeljnicaSt>();
        }
    
        public long ID
    	{
    		get { return this.ID_Davanje; }
    		set { this.ID_Davanje = value; }
    	}
        public long ID_Davanje { get; set; }
        public int IDDavanjeTablica { get; set; }
        public long IDDavanje { get; set; }
        public string Naziv { get; set; }
        public Nullable<decimal> Stopa { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public Nullable<decimal> IznosOd { get; set; }
        public Nullable<decimal> IznosDo { get; set; }
    
        public virtual DavanjeTablica DavanjeTablica { get; set; }
        public virtual ICollection<DohodakDavanje> DohodakDavanje { get; set; }
        public virtual ICollection<DohodakPrimateljDavanje> DohodakPrimateljDavanje { get; set; }
        public virtual ICollection<DohodakPrimateljPrimitakDavanje> DohodakPrimateljPrimitakDavanje { get; set; }
        public virtual ICollection<DoprinosDohodak> DoprinosDohodak { get; set; }
        public virtual ICollection<PDV> PDV { get; set; }
        public virtual ICollection<PorezDohodak> PorezDohodak { get; set; }
        public virtual ICollection<PorezDohodakPrirez> PorezDohodakPrirez { get; set; }
        public virtual ICollection<PosebanPorezDohodak> PosebanPorezDohodak { get; set; }
        public virtual ICollection<RacunIzlazSt> RacunIzlazSt { get; set; }
        public virtual ICollection<RacunUlazSt> RacunUlazSt { get; set; }
        public virtual ICollection<TemeljnicaSt> TemeljnicaSt { get; set; }
    }
}

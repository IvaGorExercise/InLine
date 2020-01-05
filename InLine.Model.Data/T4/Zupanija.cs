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
    
    public partial class Zupanija
    {
    
        public Zupanija()
        {
    
            this.Posta = new HashSet<Posta>();
            this.Ulica = new HashSet<Ulica>();
            this.Opcina = new HashSet<Opcina>();
            this.OpcinaZupanija = new HashSet<OpcinaZupanija>();
            this.ZupanijaGrZupanija = new HashSet<ZupanijaGrZupanija>();
        }
    
        public long ID
    	{
    		get { return this.ID_Zupanija; }
    		set { this.ID_Zupanija = value; }
    	}
        public long ID_Zupanija { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
        public long? ID_MjestoPosta { get; set; }
        public string TelPozBr { get; set; }
        public string SjedZup { get; set; }
        public string SjedisteZup { get; set; }
        public string PathGrb { get; set; }
        public byte[] GrbSlika { get; set; }
        public string PathKarta { get; set; }
        public byte[] KartaSlika { get; set; }
        public byte[] KartaSlika2 { get; set; }
        public string IDDrzava { get; set; }
        public long? ID_Subjekt { get; set; }
        public string OIB { get; set; }
    
        public virtual MjestoPosta MjestoPosta { get; set; }
        public virtual ICollection<Posta> Posta { get; set; }
        public virtual ICollection<Ulica> Ulica { get; set; }
        public virtual ICollection<Opcina> Opcina { get; set; }
        public virtual ICollection<OpcinaZupanija> OpcinaZupanija { get; set; }
        public virtual Subjekt Subjekt { get; set; }
        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<ZupanijaGrZupanija> ZupanijaGrZupanija { get; set; }
    }
}

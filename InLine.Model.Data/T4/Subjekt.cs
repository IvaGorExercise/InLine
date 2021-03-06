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
    
    public partial class Subjekt
    {
    
        public Subjekt()
        {
    
            this.HUB2013A = new HashSet<HUB2013A>();
            this.HUB2013A1 = new HashSet<HUB2013A>();
            this.IzvodSt = new HashSet<IzvodSt>();
            this.IzvodPosiljatelj = new HashSet<IzvodPosiljatelj>();
            this.Zaposlenje = new HashSet<Zaposlenje>();
            this.Rabat = new HashSet<Rabat>();
            this.RacunIzlaz = new HashSet<RacunIzlaz>();
            this.RacunUlaz = new HashSet<RacunUlaz>();
            this.Lokacija = new HashSet<Lokacija>();
            this.PoslovnaGodinaSubjekt = new HashSet<PoslovnaGodinaSubjekt>();
            this.PoslovniSubjekt = new HashSet<PoslovniSubjekt>();
            this.Nalog = new HashSet<Nalog>();
            this.Banka = new HashSet<Banka>();
            this.Obrt = new HashSet<Obrt>();
            this.Opcina = new HashSet<Opcina>();
            this.Osoba = new HashSet<Osoba>();
            this.Poduzece = new HashSet<Poduzece>();
            this.PoreznaUprava = new HashSet<PoreznaUprava>();
            this.SubjektEmail = new HashSet<SubjektEmail>();
            this.SubjektGrSubjekt = new HashSet<SubjektGrSubjekt>();
            this.SubjektRacun = new HashSet<SubjektRacun>();
            this.SubjektTelefon = new HashSet<SubjektTelefon>();
            this.SubjektVeza = new HashSet<SubjektVeza>();
            this.SubjektVeza1 = new HashSet<SubjektVeza>();
            this.SubjektVezaVr = new HashSet<SubjektVezaVr>();
            this.SubjektWeb = new HashSet<SubjektWeb>();
            this.TransakcijskiRacun = new HashSet<TransakcijskiRacun>();
            this.Zapis = new HashSet<Zapis>();
            this.Zapis1 = new HashSet<Zapis>();
            this.Zupanija = new HashSet<Zupanija>();
            this.TemeljnicaSt = new HashSet<TemeljnicaSt>();
            this.UgovorStanOtkup = new HashSet<UgovorStanOtkup>();
        }
    
        public long ID
    	{
    		get { return this.ID_Subjekt; }
    		set { this.ID_Subjekt = value; }
    	}
        public long ID_Subjekt { get; set; }
        public long IDSubjekt { get; set; }
        public int IDSubjektTablica { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string OIB { get; set; }
    
        public virtual ICollection<HUB2013A> HUB2013A { get; set; }
        public virtual ICollection<HUB2013A> HUB2013A1 { get; set; }
        public virtual ICollection<IzvodSt> IzvodSt { get; set; }
        public virtual ICollection<IzvodPosiljatelj> IzvodPosiljatelj { get; set; }
        public virtual ICollection<Zaposlenje> Zaposlenje { get; set; }
        public virtual ICollection<Rabat> Rabat { get; set; }
        public virtual ICollection<RacunIzlaz> RacunIzlaz { get; set; }
        public virtual ICollection<RacunUlaz> RacunUlaz { get; set; }
        public virtual ICollection<Lokacija> Lokacija { get; set; }
        public virtual ICollection<PoslovnaGodinaSubjekt> PoslovnaGodinaSubjekt { get; set; }
        public virtual ICollection<PoslovniSubjekt> PoslovniSubjekt { get; set; }
        public virtual ICollection<Nalog> Nalog { get; set; }
        public virtual ICollection<Banka> Banka { get; set; }
        public virtual ICollection<Obrt> Obrt { get; set; }
        public virtual ICollection<Opcina> Opcina { get; set; }
        public virtual ICollection<Osoba> Osoba { get; set; }
        public virtual ICollection<Poduzece> Poduzece { get; set; }
        public virtual ICollection<PoreznaUprava> PoreznaUprava { get; set; }
        public virtual SubjektTablica SubjektTablica { get; set; }
        public virtual ICollection<SubjektEmail> SubjektEmail { get; set; }
        public virtual ICollection<SubjektGrSubjekt> SubjektGrSubjekt { get; set; }
        public virtual ICollection<SubjektRacun> SubjektRacun { get; set; }
        public virtual ICollection<SubjektTelefon> SubjektTelefon { get; set; }
        public virtual ICollection<SubjektVeza> SubjektVeza { get; set; }
        public virtual ICollection<SubjektVeza> SubjektVeza1 { get; set; }
        public virtual ICollection<SubjektVezaVr> SubjektVezaVr { get; set; }
        public virtual ICollection<SubjektWeb> SubjektWeb { get; set; }
        public virtual ICollection<TransakcijskiRacun> TransakcijskiRacun { get; set; }
        public virtual ICollection<Zapis> Zapis { get; set; }
        public virtual ICollection<Zapis> Zapis1 { get; set; }
        public virtual ICollection<Zupanija> Zupanija { get; set; }
        public virtual ICollection<TemeljnicaSt> TemeljnicaSt { get; set; }
        public virtual ICollection<UgovorStanOtkup> UgovorStanOtkup { get; set; }
    }
}

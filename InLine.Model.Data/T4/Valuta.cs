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
    
    public partial class Valuta
    {
    
        public Valuta()
        {
    
            this.Temeljnica = new HashSet<Temeljnica>();
            this.TemeljnicaVr = new HashSet<TemeljnicaVr>();
            this.HUB2013A = new HashSet<HUB2013A>();
            this.HUB2013A1 = new HashSet<HUB2013A>();
            this.Izvod2012A = new HashSet<Izvod2012A>();
            this.Izvod2012ASt = new HashSet<Izvod2012ASt>();
            this.ZbrojniNalog2013A = new HashSet<ZbrojniNalog2013A>();
            this.ZbrojniNalog2013A1 = new HashSet<ZbrojniNalog2013A>();
            this.DatotekaIzvodGr2012A = new HashSet<DatotekaIzvodGr2012A>();
            this.RacunIzlazSt = new HashSet<RacunIzlazSt>();
            this.RacunUlazSt = new HashSet<RacunUlazSt>();
            this.PoslovnaGodina = new HashSet<PoslovnaGodina>();
            this.Nalog = new HashSet<Nalog>();
            this.UgovorStanOtkupObrok = new HashSet<UgovorStanOtkupObrok>();
            this.UgovorStanOtkupObrokPreplata = new HashSet<UgovorStanOtkupObrokPreplata>();
            this.UgovorStanOtkupObrokUplata = new HashSet<UgovorStanOtkupObrokUplata>();
            this.UgovorStanOtkupTrosak = new HashSet<UgovorStanOtkupTrosak>();
            this.DrzavaValuta = new HashSet<DrzavaValuta>();
            this.TecajListaSt = new HashSet<TecajListaSt>();
            this.TecajListaSt1 = new HashSet<TecajListaSt>();
            this.TemeljnicaSt = new HashSet<TemeljnicaSt>();
            this.UgovorStanOtkup = new HashSet<UgovorStanOtkup>();
            this.ObveznicaJavnogDugaIspravak = new HashSet<ObveznicaJavnogDugaIspravak>();
        }
    
        public string IDValuta { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Kratica2 { get; set; }
        public int Kod { get; set; }
        public int Decimale { get; set; }
        public string NazivDio { get; set; }
    
        public virtual ICollection<Temeljnica> Temeljnica { get; set; }
        public virtual ICollection<TemeljnicaVr> TemeljnicaVr { get; set; }
        public virtual ICollection<HUB2013A> HUB2013A { get; set; }
        public virtual ICollection<HUB2013A> HUB2013A1 { get; set; }
        public virtual ICollection<Izvod2012A> Izvod2012A { get; set; }
        public virtual ICollection<Izvod2012ASt> Izvod2012ASt { get; set; }
        public virtual ICollection<ZbrojniNalog2013A> ZbrojniNalog2013A { get; set; }
        public virtual ICollection<ZbrojniNalog2013A> ZbrojniNalog2013A1 { get; set; }
        public virtual ICollection<DatotekaIzvodGr2012A> DatotekaIzvodGr2012A { get; set; }
        public virtual ICollection<RacunIzlazSt> RacunIzlazSt { get; set; }
        public virtual ICollection<RacunUlazSt> RacunUlazSt { get; set; }
        public virtual ICollection<PoslovnaGodina> PoslovnaGodina { get; set; }
        public virtual ICollection<Nalog> Nalog { get; set; }
        public virtual ICollection<UgovorStanOtkupObrok> UgovorStanOtkupObrok { get; set; }
        public virtual ICollection<UgovorStanOtkupObrokPreplata> UgovorStanOtkupObrokPreplata { get; set; }
        public virtual ICollection<UgovorStanOtkupObrokUplata> UgovorStanOtkupObrokUplata { get; set; }
        public virtual ICollection<UgovorStanOtkupTrosak> UgovorStanOtkupTrosak { get; set; }
        public virtual ICollection<DrzavaValuta> DrzavaValuta { get; set; }
        public virtual ICollection<TecajListaSt> TecajListaSt { get; set; }
        public virtual ICollection<TecajListaSt> TecajListaSt1 { get; set; }
        public virtual ICollection<TemeljnicaSt> TemeljnicaSt { get; set; }
        public virtual ICollection<UgovorStanOtkup> UgovorStanOtkup { get; set; }
        public virtual ICollection<ObveznicaJavnogDugaIspravak> ObveznicaJavnogDugaIspravak { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drzava
    {
        public Drzava()
        {
            this.Drzava1 = new HashSet<Drzava>();
        }
    
        public int IDDrzava { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string NazivEn { get; set; }
        public string NazivFr { get; set; }
        public int? Kod { get; set; }
        public bool Teritorij { get; set; }
        public int? IDDrzavaNad { get; set; }
        public string SifDrzava { get; set; }
        public string OznDrzava { get; set; }
        public string ISO3166 { get; set; }
        public string FIPS104 { get; set; }
        public string Internet { get; set; }
        public string OznHr { get; set; }
        public string OznEng { get; set; }
        public string NazivHr { get; set; }
        public string NazivHrDugi { get; set; }
        public string NazivEng { get; set; }
        public string NazivEngDugi { get; set; }
        public string NazivLokal { get; set; }
        public string NazivLokalDugi { get; set; }
        public string NazivStariHr { get; set; }
        public string NazivStariEng { get; set; }
        public string Kratica1 { get; set; }
        public string Nacija { get; set; }
        public string Obuhvat { get; set; }
        public string Napomena { get; set; }
        public string Komentar { get; set; }
        public string StsDrzava { get; set; }
        public bool? IzborDrzava { get; set; }
        public string ZastavaV { get; set; }
        public string ZastavaM { get; set; }
        public string ZastavaMPath { get; set; }
        public string ZastavaVPath { get; set; }
        public string GrbV { get; set; }
        public string GrbM { get; set; }
        public string GrbVPath { get; set; }
        public string GrbMPath { get; set; }
        public string KartaV { get; set; }
        public string KartaM { get; set; }
        public string KartaMPath { get; set; }
        public string KartaVPath { get; set; }
        public string DrzavaHtml1 { get; set; }
        public string DrzavaHtml2 { get; set; }
        public string DrzavaHtml3 { get; set; }
        public string DrzavaHtml4 { get; set; }
    
        public virtual ICollection<Drzava> Drzava1 { get; set; }
        public virtual Drzava Drzava2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InLine.UI.Web.Models.ViewModelCustom
{
    public class ObrociGrad
    {
        [DisplayName("Mjesec i godina obroka")]
        //[Range(1, 12, ErrorMessage = "1-12")]
        [RegularExpression("^[0-9]*", ErrorMessage = "Brojevi!")]
        public int Mjesec { get; set; }

        //[Range(1990, 2030, ErrorMessage = "1990-2030")]
        public int Godina { get; set; }

        public InLine.Model.Admin.StatusPoruka StatusPoruka { get; set; }

        [DisplayName("Od ugovora")]
        public int BrojUgovorMin { get; set; }

        [DisplayName("Min String")]
        public String BrojUgovorMinString { get; set; }

        [DisplayName("Do ugovora")]
        public int BrojUgovorMax { get; set; }

        [DisplayName("Max String")]
        public String BrojUgovorMaxString { get; set; }

        [DisplayName("Poruka")]
        [DataType(DataType.MultilineText)]
        public string Poruka { get; set; }

        //[DisplayName("Valuta revalorizacije")]
        //public string IDValuta { get; set; }

        [DisplayName("Uvjet revalorizacije")]
        public decimal UvjetRevalorizacije { get; set; }

        [DisplayName("Unaprijed")]
        public bool Unaprijed { get; set; }

        [DisplayName("Preplata")]
        public bool Preplata { get; set; }

        [DisplayName("Kamata")]
        public bool Kamata { get; set; }

        public int FormiranjePocelo { get; set; }

    }

    public class ObrociGradObrada
    {
      
        public int Ugovor { get; set; }

        public int ObrokUgovora { get; set; }

        public int FormiranoObroka { get; set; }

        public String TecajValutaRevalorizacije { get; set; }

        public String TecajValutaRevalorizacijeDEM { get; set; }

        public String VrijemePocetak { get; set; }

        public String VrijemeTrenutno { get; set; }

        public String VrijemeKraj { get; set; }

        public String TrajanjeDoSada { get; set; }

        public String TrajanjeDoKraja { get; set; }

        public String TrajanjeUkupno { get; set; }

        public String UgovoriObradjeni { get; set; }

        public String UgovoriZaObradu { get; set; }

        public String UgovoriUkupno { get; set; }

        public String VrstaObrocniOtvoreni { get; set; }

        public String VrstaObrocniZatvoreni { get; set; }

        public String VrstaObrocniUkupno { get; set; }

        public String VrstaJednokratno { get; set; }

        public String VrstaUkupno { get; set; }

        public int FormiranjeZavrseno { get; set; }

        public int Status { get; set; }

    }
}
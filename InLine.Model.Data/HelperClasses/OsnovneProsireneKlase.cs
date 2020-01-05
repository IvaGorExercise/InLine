using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InLine.Model.Data
{
    public class OsnovneProsireneKlase
    {
        public class PoslovniSubjektProsireni : PoslovniSubjekt
        {
            public string NazivSubjekta { get; set; }
            public string SubjektTablicaNaziv { get; set; }
        }
    }
}

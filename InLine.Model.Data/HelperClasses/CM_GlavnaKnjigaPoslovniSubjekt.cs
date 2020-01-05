using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InLine.Model.Data
{
    public class CM_GlavnaKnjigaPoslovniSubjekt
    {
        public long ID_GlavnaKnjiga { get; set; }
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public string NazivIGodina
        {
            get
            {
                //return Naziv + " - " + Godina.ToString();
                return Godina.ToString() + " |--------| " + Naziv;
            }
        }
    }
}

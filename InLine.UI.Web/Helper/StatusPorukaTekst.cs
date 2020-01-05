using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InLine.UI.Web.Helper
{
    public class StatusPorukaTekst
    {
        public static class Poruka
        {
            public const string NijeKnizeno = "Nisu ispunjeni uvjeti za knjiženje temeljnice";
            public const string KriterijMax6 = "Najveći dozvoljeni broj kriterija je 6. Unos novog kriterija nije dozvoljen dok se ne obriše barem jedan postojeći kriterij. Uređivanje postojećih kriterija je dozvoljeno";
        }

        public static class Status
        {
            public const string Jedan = "1";
            public const string Dva = "2";
            public const string Tri = "3";
        }
    }
}
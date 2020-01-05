using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using InLine;

namespace InLine.Repository.Admin
{
    public class KorisnikDataFromSession : IKorisnikDataFromSession
    {
        public Model.Admin.KorisnikData GetKorisnikDataFromSession()
        {
            Model.Admin.KorisnikData korisnik_data = new Model.Admin.KorisnikData();

            if (System.Web.HttpContext.Current.Session != null)
            {
                if (HttpContext.Current.Session["Korisnik" + HttpContext.Current.Session["KorisnikID"]] != null && (HttpContext.Current.Session["Korisnik" + HttpContext.Current.Session["KorisnikID"]].ToString() != String.Empty))
                {
                    korisnik_data = HttpContext.Current.Session["Korisnik" + HttpContext.Current.Session["KorisnikID"]] as Model.Admin.KorisnikData;
                }

                else
                {
                    korisnik_data = null;
                }
            }

            return korisnik_data;
        }
    }
}

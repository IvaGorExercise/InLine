using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Objects;
using InLine;

namespace InLine.Repository.Admin
{
    public class KorisnikVijest : IKorisnikVijest
    {
        Model.Admin.Context _context = new Model.Admin.Context();

        //public IEnumerable<Model.Admin.Vijest> GetVijestiForKorisnik(long KorisnikID)
        //{
        //    ObjectResult<Model.Admin.Vijest> rez = _context.USP_Vijesti(KorisnikID, DateTime.Now.Date);
        //    return rez as IEnumerable<Model.Admin.Vijest>;
        //}
    }
}

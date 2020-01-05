using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InLine.Repository.Data.View
{
    public partial class HUB2013A
    {
        public int HUB_IMPORT(Repository.Data.Helper.HUB_IMPORT item)
        {
            //_context.Database.Connection.;
            return _context.C_USP_HUB_IMPORT(item.Datoteka, item.Godina, item.Mjesec, item.IDHUBNamjena2013A);
        }

        //public int? HUB_IMPORT(Repository.Data.Helper.HUB_IMPORT item)
        //{
        //    return _context.Database.SqlQuery(int)("ots.C_USP_HUB_IMPORT", item.Datoteka, item.Godina, item.Mjesec, item.Datum, item.IDHUBNamjena2013A);

        //}

        public int HUB_IMPORT_TestBrojUgovora(Repository.Data.Helper.HUB_IMPORT item)
        {

            return _context.C_USP_HUB_IMPORT_TestBrojUgovora(item.Datoteka, item.Godina, item.Mjesec, item.IDHUBNamjena2013A, item.BrojUgovorMin, item.BrojUgovorMax);
        }

        public int HUB_IMPORT_Test(Repository.Data.Helper.HUB_IMPORT item)
        {
            return _context.C_USP_HUB_IMPORT_Test(item.Godina, item.Mjesec, item.BrojUgovorMin, item.BrojUgovorMax, item.IDHUBNamjena2013A, item.Datoteka);
        }
    }
}

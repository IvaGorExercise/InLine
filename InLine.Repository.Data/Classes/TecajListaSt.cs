using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Xml.Linq;

namespace InLine.Repository.Data
{
    public partial class TecajListaSt
    {
        public ObjectResult<Model.Data.TecajListaSt> TecajnaListaStInsert_Complex( Model.Data.TecajListaSt item, String data)
        {
            return _context.C_USP_TecajListaSt_INSERT(item.ID_TecajLista, item.IDDrzavaIz, item.IDDrzavaU, item.IDValutaIz, item.IDValutaU, item.BrojJedinica, data);
        }

        public ObjectResult<Model.Data.TecajListaSt> TecajnaListaStUpdate_Complex(Model.Data.TecajListaSt item, String data)
        {
            return _context.C_USP_TecajListaSt_UPDATE(item.ID_TecajListaSt, item.ID_TecajLista, item.IDDrzavaIz, item.IDDrzavaU, item.IDValutaIz, item.IDValutaU, item.BrojJedinica, data);
        }

        public ObjectResult<int?> TecajnaListaStDelete_Complex(Model.Data.TecajListaSt item)
        {
            return _context.C_USP_TecajListaSt_DELETE(item.ID_TecajListaSt);
        }

        public ObjectResult<Model.Data.TecajLista> TecajnaListaDownloadInsert(Model.Data.TecajLista item, String data)
        {
            return _context.C_USP_TecajListaDownload_INSERT(item.ID_Banka, item.Datum, item.RedniBroj, item.Godina,  item.GodinaRedniBroj, data);
        }
    }
}

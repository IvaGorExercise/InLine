using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace InLine.Repository.Data
{
    public partial interface ITecajListaSt
    {
        ObjectResult<Model.Data.TecajListaSt> TecajnaListaStInsert_Complex(Model.Data.TecajListaSt item, String data);
        ObjectResult<Model.Data.TecajListaSt> TecajnaListaStUpdate_Complex(Model.Data.TecajListaSt item, String data);
        ObjectResult<int?> TecajnaListaStDelete_Complex(Model.Data.TecajListaSt item);
        ObjectResult<Model.Data.TecajLista> TecajnaListaDownloadInsert(Model.Data.TecajLista item, String data);
    }
}
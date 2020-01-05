using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace InLine.Service.Data
{
    public partial class TecajListaSt
    {

        public ObjectResult<Model.Data.TecajListaSt> TecajnaListaStInsert_Complex( Model.Data.TecajListaSt item, String data)
        {
            ObjectResult<Model.Data.TecajListaSt> result = null;

            try
            {
                result = _repository.TecajnaListaStInsert_Complex(item, data);
            }

            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);

            }

            return result;

        }

        public ObjectResult<Model.Data.TecajListaSt> TecajnaListaStUpdate_Complex(Model.Data.TecajListaSt item, String data)
        {
            ObjectResult<Model.Data.TecajListaSt> result = null;

            try
            {
                result = _repository.TecajnaListaStUpdate_Complex(item, data);
            }

            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);

            }

            return result;

        }

        public ObjectResult<int?> TecajnaListaStDelete_Complex(Model.Data.TecajListaSt item)
        {
            ObjectResult<int?> result = null;

            try
            {
                result = _repository.TecajnaListaStDelete_Complex(item);
            }

            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);

            }

            return result;

        }


        public ObjectResult<Model.Data.TecajLista> TecajnaListaDownloadInsert(Model.Data.TecajLista item, String data)
        {
            ObjectResult<Model.Data.TecajLista> result = null;

            try
            {
                result = _repository.TecajnaListaDownloadInsert(item, data);
            }

            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);

            }

            return result;

        }


    }
}
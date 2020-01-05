using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace InLine.Service.Data
{
    public partial class Banka
    {
      
        public ObjectResult<Model.Data.Banka> InsertResultComplex(Model.Data.Item.BankaItem item1, Model.Data.Item.SubjektEmailItem item2, Model.Data.Item.SubjektTelefonItem item3, Model.Data.Item.SubjektRacunItem item4)
        {
            ObjectResult<Model.Data.Banka> result = null;
      
            try
            {
              result = _repository.InsertResultComplex(item1, item2, item3, item4);
            }

            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);

            }

            return result;

        }



        //public IEnumerable<Model.Data.C_USP_BankaComplex_INSERT_Result> BankaComplex_INSERT_Result(long? ID_Banka)
        //{
        //    return _repository.BankaComplex_INSERT_Result(ID_Banka);
        //}

    }
}

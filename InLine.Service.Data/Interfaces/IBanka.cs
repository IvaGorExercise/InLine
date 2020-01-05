using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InLine;
using System.Data.Objects;

namespace InLine.Service.Data
{
    public partial interface IBanka
    {
       ObjectResult<Model.Data.Banka> InsertResultComplex(Model.Data.Item.BankaItem item1, Model.Data.Item.SubjektEmailItem item2, Model.Data.Item.SubjektTelefonItem item3, Model.Data.Item.SubjektRacunItem item4);
       //IEnumerable<Model.Data.C_USP_BankaComplex_INSERT_Result> BankaComplex_INSERT_Result(long? ID_Banka);
    }
}

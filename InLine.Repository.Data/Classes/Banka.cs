using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Data.Objects;
using InLine;


namespace InLine.Repository.Data
{
    public partial class Banka 
    {
        public ObjectResult<Model.Data.Banka> InsertResultComplex(Model.Data.Item.BankaItem item1, Model.Data.Item.SubjektEmailItem item2, Model.Data.Item.SubjektTelefonItem item3, Model.Data.Item.SubjektRacunItem item4)
        {
            return _context.C_USP_Banka_INSERT(item1.ID_Subjekt, item1.Oznaka, item1.Naziv, item1.NazivKr, item1.Kratica, item1.VBDI, item1.Swift, item1.DealingCode, item1.FINAModel, item1.OIB, item2.URL, item2.Opis, item3.Broj, item4.ID_Banka, item4.Broj, item4.VBDI, item4.IBAN);
        }


        //public IEnumerable<Model.Data.C_USP_BankaComplex_INSERT_Result> BankaComplex_INSERT_Result(long? ID_Banka)
        //{
        //    return _context.C_USP_BankaComplex_INSERT(ID_Banka);
        //}

        //public ObjectResult<Model.Data.Banka> InsertResultComplex(Model.Data.Item.BankaItem item1, Model.Data.Item.SubjektEmailItem item2, Model.Data.Item.SubjektTelefonItem item3, Model.Data.Item.SubjektRacunItem item4)
        //{
        //    return _context.C_USP_Banka_INSERT(item1.ID_Subjekt, item1.Oznaka, item1.Naziv, item1.NazivKr, item1.Kratica, item1.VBDI, item1.Swift, item1.DealingCode, item1.FINAModel, item1.OIB, item2.URL, item2.Opis, item3.Broj, item4.ID_Banka, item4.Broj, item4.VBDI, item4.IBAN);
        //}

    }
}


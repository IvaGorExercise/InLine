using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace InLine.Service.Data
{
    public partial class Temeljnica
    {

        # region Konstruktor

        Repository.Data.ITemeljnicaSt _repositoryTemeljnicaSt;

        #endregion



        public IDictionary<string, decimal> TemeljnicaSaldoStavki(long Id)
        {
            _repositoryTemeljnicaSt = new Repository.Data.TemeljnicaSt(_korisnik_data.ConnString);

            Dictionary<string, decimal> lista = new Dictionary<string, decimal>();

            List<InLine.Model.Data.Field.TemeljnicaSt> field = new List<InLine.Model.Data.Field.TemeljnicaSt>();
            List<InLine.Model.Data.Filter.TemeljnicaSt> filter = new List<InLine.Model.Data.Filter.TemeljnicaSt>();
            List<InLine.Model.Data.Sort.TemeljnicaSt> sort = new List<InLine.Model.Data.Sort.TemeljnicaSt>();
            filter.Add(new InLine.Model.Data.Filter.TemeljnicaSt { Field = InLine.Model.Data.Field.TemeljnicaSt.ID_Temeljnica, Value = Convert.ToInt64(Id) });

            var query = _repositoryTemeljnicaSt.GetData(field, filter, sort).ToList();
              
            if (query.Any())
            {
                lista.Add(InLine.Model.Data.FieldString.TemeljnicaSt.IznosDuguje, Convert.ToDecimal(query.Sum(p=>p.IznosDuguje)));
                lista.Add(InLine.Model.Data.FieldString.TemeljnicaSt.IznosPotrazuje, Convert.ToDecimal(query.Sum(p=>p.IznosPotrazuje)));
                lista.Add(InLine.Model.Data.FieldString.TemeljnicaSt.IznosDugujeValuta, Convert.ToDecimal(query.Sum(p=>p.IznosDugujeValuta)));
                lista.Add(InLine.Model.Data.FieldString.TemeljnicaSt.IznosPotrazujeValuta, Convert.ToDecimal(query.Sum(p=>p.IznosPotrazujeValuta)));
            }

            return lista;
        }

        public bool IsSaldoStavkiNula(long Id)
        {
            bool proof = false;
            decimal IzosDugujeSuma = 0;
            decimal IzosPotrazujeSuma = 0;
            decimal IzosDugujeValSuma = 0;
            decimal IzosPotrazujeValSuma = 0;
            decimal SumaDomaca = 0;
            decimal SumaValuta = 0;

            IDictionary<string, decimal> listsuma;

            listsuma = TemeljnicaSaldoStavki(Id);
            List<string> list = new List<string>(listsuma.Keys);

            if (listsuma.Any())
            {
                IzosDugujeSuma = listsuma[InLine.Model.Data.FieldString.TemeljnicaSt.IznosDuguje];
                IzosPotrazujeSuma = listsuma[InLine.Model.Data.FieldString.TemeljnicaSt.IznosPotrazuje];
                IzosDugujeValSuma = listsuma[InLine.Model.Data.FieldString.TemeljnicaSt.IznosDugujeValuta];
                IzosPotrazujeValSuma = listsuma[InLine.Model.Data.FieldString.TemeljnicaSt.IznosPotrazujeValuta];

                SumaDomaca = IzosDugujeSuma - IzosPotrazujeSuma;
                SumaValuta = IzosDugujeValSuma - IzosPotrazujeValSuma;

                if (SumaDomaca == 0 && SumaValuta == 0)
                {
                    proof = true;
                }

            }
       
            return proof;
        }

    }
}

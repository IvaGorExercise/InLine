using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace InLine.UI.Web.Models.ViewModelCustom
{
    public class KupacUgovorCustomSearch
    {
        #region Properties

        public int? BrojUgovor { get; set; }
        public string Naziv { get; set; }
        public string UlicaKupac { get; set; }
        public string UlicaStan { get; set; }


        #endregion

        #region Methods
        public string GetFilterExpression()
        {
            StringBuilder filterExpressionBuilder = new StringBuilder();
            if (BrojUgovor > 0)
                filterExpressionBuilder.Append(String.Format("CAST(BrojUgovor as varchar(10)) LIKE '%{0}%'  AND ", BrojUgovor));
            if (!String.IsNullOrWhiteSpace(Naziv))
                filterExpressionBuilder.Append(String.Format("Naziv LIKE '%{0}%' AND ", Naziv));
            if (!String.IsNullOrWhiteSpace(UlicaKupac))
                filterExpressionBuilder.Append(String.Format("UlicaKupac LIKE '%{0}%' AND ", UlicaKupac));
            if (!String.IsNullOrWhiteSpace(UlicaStan))
                filterExpressionBuilder.Append(String.Format("UlicaStan LIKE '%{0}%' AND ", UlicaStan));
            if (filterExpressionBuilder.Length > 0)
                filterExpressionBuilder.Remove(filterExpressionBuilder.Length - 5, 5);
            return filterExpressionBuilder.ToString();
        }
        #endregion
    }
}
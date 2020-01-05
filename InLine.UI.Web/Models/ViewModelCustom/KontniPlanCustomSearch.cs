using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace InLine.UI.Web.Models.ViewModelCustom
{
    public class KontniPlanCustomSearch
    {
        #region Properties

        public int Godina { get; set; }
        public string Naziv { get; set; }
        public string IDValuta { get; set; }

        #endregion

        #region Methods
        public string GetFilterExpression()
        {
            StringBuilder filterExpressionBuilder = new StringBuilder();
            if (Godina > 0)
                filterExpressionBuilder.Append(String.Format("CAST(Godina as varchar(10)) LIKE '%{0}%'  AND ", Godina));
            if (!String.IsNullOrWhiteSpace(Naziv))
                filterExpressionBuilder.Append(String.Format("Naziv LIKE '%{0}%' AND ", Naziv));
            if (!String.IsNullOrWhiteSpace(IDValuta))
                filterExpressionBuilder.Append(String.Format("IDValuta LIKE '%{0}%' AND ", IDValuta));
            if (filterExpressionBuilder.Length > 0)
                filterExpressionBuilder.Remove(filterExpressionBuilder.Length - 5, 5);
            return filterExpressionBuilder.ToString();
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace InLine.UI.Web.Models.ViewModelCustom
{
    public class GlavnaKnjigaCustomSearch
    {
        #region Properties

        public long ID_GlavnaKnjiga { get; set; }
        public int Godina { get; set; }
        public string Naziv { get; set; }
        public string OIB { get; set; }


        #endregion

        #region Methods
        public string GetFilterExpression()
        {
            StringBuilder filterExpressionBuilder = new StringBuilder();
            if (ID_GlavnaKnjiga > 0)
                filterExpressionBuilder.Append(String.Format("CAST(ID_GlavnaKnjiga as varchar(10)) LIKE '%{0}%'  AND ", ID_GlavnaKnjiga));
            if (Godina > 0)
                filterExpressionBuilder.Append(String.Format("CAST(Godina as varchar(10)) LIKE '%{0}%'  AND ", Godina));
            if (!String.IsNullOrWhiteSpace(Naziv))
                filterExpressionBuilder.Append(String.Format("Naziv LIKE '%{0}%' AND ", Naziv));
            if (!String.IsNullOrWhiteSpace(OIB))
                filterExpressionBuilder.Append(String.Format("OIB LIKE '%{0}%' AND ", OIB));
            if (filterExpressionBuilder.Length > 0)
                filterExpressionBuilder.Remove(filterExpressionBuilder.Length - 5, 5);
            return filterExpressionBuilder.ToString();
        }
        #endregion
    }
}
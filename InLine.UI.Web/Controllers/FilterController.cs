using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lib.Web.Mvc.JQuery.JqGrid;
using System.Text;
using InLine.UI.Web.Models.ViewModelCustom;
using InLine.UI.Web.T4.GridFormattedTemplate.View;
using InLine.UI.Web.T4.FormFormattedTemplate;
using InLine.Model.Admin;
using InLine.UI.Web.Helper;


namespace InLine.UI.Web.Controllers
{
    public class FilterController : InLine.UI.Web.Controllers.DrzavaController
    {
        Service.Data.IDrzavljanstvo _serviceDrzavljanstvo;
        Service.Data.INarodnost _serviceNarodnost;

        public ActionResult BoolFilter()
        {
            Dictionary<long, string> dict = new Dictionary<long, string>();
            dict = BoolDictionary();
            return PartialView("Select", dict);
        }

        public Dictionary<long, string> BoolDictionary()
        {
            Dictionary<long, string> dict = new Dictionary<long, string>();
            dict.Add(1, "Da");
            dict.Add(0, "Ne");
            return dict;
        }


        public ActionResult DrzavljanstvoFilter()
        {
            Dictionary<long, string> dict = new Dictionary<long, string>();
            _serviceDrzavljanstvo = new Service.Data.Drzavljanstvo(korisnik_data);

            IEnumerable<Model.Data.Drzavljanstvo> rezult = _serviceDrzavljanstvo.SelectResult(null).ToList();

            foreach (Model.Data.Drzavljanstvo element in rezult)
                dict.Add(element.ID_Drzavljanstvo, element.Naziv);
            return PartialView("Select", dict);
        }

        public ActionResult NarodnostFilter()
        {
            Dictionary<long, string> dict = new Dictionary<long, string>();
            _serviceNarodnost = new Service.Data.Narodnost(korisnik_data);

            IEnumerable<Model.Data.Narodnost> rezult = _serviceNarodnost.SelectResult(null).ToList();

            foreach (Model.Data.Narodnost element in rezult)
                dict.Add(element.ID_Narodnost, element.Naziv);
            return PartialView("Select", dict);
        }

    }
}

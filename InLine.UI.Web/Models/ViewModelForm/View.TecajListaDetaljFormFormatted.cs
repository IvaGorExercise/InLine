

namespace InLine.UI.Web.T4.FormFormattedTemplate.View
{

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Web;
    using System.ComponentModel;
    using Lib.Web.Mvc.JQuery.JqGrid.DataAnnotations;
    using Lib.Web.Mvc.JQuery.JqGrid;
    using System.ComponentModel.DataAnnotations;
    using Lib.Web.Mvc.JQuery.JqGrid.Constants;
    using System.Web.Mvc;
    using InLine;
    using InLine.UI.Web.T4.FormFormattedTemplate;
    using InLine.UI.Web.Helper;


    public partial class TecajListaDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.TecajListaDetalj.ID_TecajLista.Required)]
        [DisplayName(AtributClass.TecajListaDetalj.ID_TecajLista.DisplayName)]
        public long ID_TecajLista { get; set; }

        [Required(ErrorMessage = AtributClass.TecajListaDetalj.ID_Banka.Required)]
        [DisplayName(AtributClass.TecajListaDetalj.ID_Banka.DisplayName)]
        public long ID_Banka { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.TecajListaDetalj.Datum.Required)]
        [DisplayName(AtributClass.TecajListaDetalj.Datum.DisplayName)]
        public System.DateTime Datum { get; set; }

        [Required(ErrorMessage = AtributClass.TecajListaDetalj.RedniBroj.Required)]
        [DisplayName(AtributClass.TecajListaDetalj.RedniBroj.DisplayName)]
        public int RedniBroj { get; set; }

        [DisplayName(AtributClass.TecajListaDetalj.Godina.DisplayName)]
        public Nullable<int> Godina { get; set; }

        [DisplayName(AtributClass.TecajListaDetalj.GodinaRedniBroj.DisplayName)]
        public Nullable<int> GodinaRedniBroj { get; set; }

        #endregion

        #region Constructor

        public TecajListaDetaljFormFormatted()
        { }

        public TecajListaDetaljFormFormatted(Model.Data.View.TecajListaDetalj formformated)
        {
            this.ID_TecajLista = formformated.ID_TecajLista;
            this.ID_Banka = formformated.ID_Banka;
            this.Datum = formformated.Datum;
            this.RedniBroj = formformated.RedniBroj;
            this.Godina = formformated.Godina;
            this.GodinaRedniBroj = formformated.GodinaRedniBroj;
        }


        #endregion

    }
}


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


    public partial class OpomenaDetaljFormFormatted
    {
        #region Properities

      
        [RegularExpression(KeyWord.FormaterRazno.ConstraintPoruka.ConstraintUnosBrojevi, ErrorMessage = KeyWord.FormaterRazno.ConstraintPoruka.SamoUnosBrojeva)]
        [Required(ErrorMessage = AtributClass.OpomenaDetalj.BrojOpomena.Required)]
        [DisplayName(AtributClass.OpomenaDetalj.BrojOpomena.DisplayName)]
        public int BrojOpomena { get; set; }

        [Required(ErrorMessage = AtributClass.OpomenaDetalj.ID_Opomena.Required)]
        [DisplayName(AtributClass.OpomenaDetalj.ID_Opomena.DisplayName)]
        public long ID_Opomena { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "*")]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.OpomenaDetalj.DatumDospijeceDo.DisplayName)]
        public Nullable<System.DateTime> DatumDospijeceDo { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "*")]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.OpomenaDetalj.DatumDospijeceOd.DisplayName)]
        public Nullable<System.DateTime> DatumDospijeceOd { get; set; }

        [DisplayName(AtributClass.OpomenaDetalj.ID_Zapis.DisplayName)]
        public Nullable<long> ID_Zapis { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName(AtributClass.OpomenaDetalj.OpomenaIznosMin.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> OpomenaIznosMin { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName(AtributClass.OpomenaDetalj.BrojNeplaceniObrokMin.DisplayName)]
        public Nullable<int> BrojNeplaceniObrokMin { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.OpomenaDetalj.Datum.DisplayName)]
        public Nullable<System.DateTime> Datum { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.OpomenaDetalj.DatumInsert.DisplayName)]
        public Nullable<System.DateTime> DatumInsert { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.OpomenaDetalj.OsobaInsert.StringLength)]
        [DisplayName(AtributClass.OpomenaDetalj.OsobaInsert.DisplayName)]
        public string OsobaInsert { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.OpomenaDetalj.DatumUpdate.DisplayName)]
        public Nullable<System.DateTime> DatumUpdate { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.OpomenaDetalj.OsobaUpdate.StringLength)]
        [DisplayName(AtributClass.OpomenaDetalj.OsobaUpdate.DisplayName)]
        public string OsobaUpdate { get; set; }

        [DisplayName(AtributClass.OpomenaDetalj.ID_OsobaInsert.DisplayName)]
        public Nullable<long> ID_OsobaInsert { get; set; }

        [DisplayName(AtributClass.OpomenaDetalj.ID_OsobaUpdate.DisplayName)]
        public Nullable<long> ID_OsobaUpdate { get; set; }

        #endregion

        #region Constructor

        public OpomenaDetaljFormFormatted()
        { }

        public OpomenaDetaljFormFormatted(Model.Data.View.OpomenaDetalj formformated)
        {
            this.Datum = formformated.Datum;
            this.BrojOpomena = formformated.BrojOpomena;
            this.ID_Opomena = formformated.ID_Opomena;
            this.DatumDospijeceOd = formformated.DatumDospijeceOd;
            this.DatumDospijeceDo = formformated.DatumDospijeceDo;
            this.ID_Zapis = formformated.ID_Zapis;
            this.OpomenaIznosMin = formformated.OpomenaIznosMin;
            this.BrojNeplaceniObrokMin = formformated.BrojNeplaceniObrokMin;
            this.DatumInsert = formformated.DatumInsert;
            this.OsobaInsert = formformated.OsobaInsert;
            this.DatumUpdate = formformated.DatumUpdate;
            this.OsobaUpdate = formformated.OsobaUpdate;
            this.ID_OsobaInsert = formformated.ID_OsobaInsert;
            this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
        }


        #endregion

    }
}

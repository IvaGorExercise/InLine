
var Dialozi = function () {

    InsertEditMaster = function (tablica, grid, mastergrid, kontroler, dialog, tip, sirina, visina, title, porukaDiv = "Master") {

        var kojidialog = "#" + tablica + "Dialog";
        var kojikontroler = "../" + kontroler + "/";
        var kojigrid = "#" + grid;
        var loader = kojikontroler + dialog + "Detalj/";
        var kojasirina = sirina;
        var kojavisina = visina;
        var kojaforma = "#" + tablica + "Form";
        var kojimastergrid = "#" + mastergrid;
        var kojaakcija = tablica + "Insert";
        var kontrolerakcija = kojikontroler + kojaakcija;
        var kojitip = tip;
        var kojititle = title;
        var kojaakcijaDelete = tablica + "Delete";
        var kontrolerakcijaDelete = kojikontroler + kojaakcijaDelete;
        var kojaPorukaDiv = "Master";

        if(porukaDiv != "Master")
        {
            kojaPorukaDiv = porukaDiv;
        }

        var masterId = null;
        var slaveId = $(kojigrid).jqGrid('getGridParam', 'selrow');


        if (kojitip == "Insert") {
            kojititle = kojititle + " UNOS "
        }
        else if (kojitip == "Edit") {
            kojititle = kojititle + " DETALJ "
        }

        // Iniciranje Dialoga
        $(function () {
            $(kojidialog).dialog({
                autoOpen: false,
                show: {
                    effect: "none",
                    duration: 0
                },
                hide: {
                    effect: "none",
                    duration: 0
                },
                width: sirina,
                height: visina,
                modal: true,
                resizable: true,
                position: 'top',
                draggable: true,
                title: kojititle,
                buttons: {
                    Spremi:
                    {
                        text: "Spremi",
                        id: kojidialog + "Spremi",
                        value: "Spremi",
                        click: function () {
                            var frm = kojaforma;
                            var serializeData = $(kojaforma).serialize();

                            if ($(frm).validate().form()) {
                                $.ajax({
                                    url: kontrolerakcija,
                                    data: serializeData,
                                    type: 'POST',
                                    success: function (data) {
                                        if (data.length > 0) {
                                            porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                        }

                                        jQuery(kojigrid).trigger('reloadGrid');

                                    }
                                });
                            }

                        }

                    },

                    Obriši:
                    {
                        text: "Obriši",
                        id: kojidialog + "Obrisi",
                        value: "Obrisi",

                        click: function () {
                            if (slaveId == null) {
                                alert('Nije odabrana stavka');
                            }

                            else {
                                if (confirm('Da li sigurno želite obrisati stavku?')) {

                                    var frm = kojaforma;
                                    var serializeData = $(kojaforma).serialize();
                                    $.ajax({
                                        url: kontrolerakcijaDelete,
                                        data: serializeData,
                                        type: 'POST',
                                        success: function (data) {
                                            if (data.length > 0) {
                                                 porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                            }

                                            jQuery(kojigrid).trigger('reloadGrid');

                                        }
                                    });
                                }

                            }
                        }
                    },


                    Zatvori: function () {
                        $(this).dialog("close");
                            $(this).empty();
                    }
                }
            });
        });


        // Otvaranje Forme i Dialoga ovisno o tipu kacije

        if (kojitip == "Insert") {
            slaveId = null
            $(kojidialog).dialog("open").load(loader, { Id: slaveId, IdMaster: masterId })
        }

        else if (kojitip == "Edit") {
            if (slaveId == null) {
                $.jgrid.viewModal("#alertmod", { gbox: "#gbox_" + kojirgrid, jqm: true });
                $("#jqg_alrt").focus();
            }
            else {
                $(kojidialog).dialog("open").load(loader, { Id: slaveId, IdMaster: masterId })

            }
        }
    };

    InsertEditSlave = function (tablica, grid, mastergrid, kontroler, dialog, tip, sirina, visina, title, porukaDiv = "Master") {

    alert("Inser edit slave");

        var kojidialog = "#" + tablica + "Dialog";
        var kojikontroler = "../" + kontroler + "/";
        var kojigrid = "#" + grid;
        var loader = kojikontroler + dialog + "Detalj/";
        var kojasirina = sirina;
        var kojavisina = visina;
        var kojaforma = "#" + tablica + "Form";
        var kojimastergrid = "#" + mastergrid;
        var kojaakcija = tablica + "Insert";
        var kontrolerakcija = kojikontroler + kojaakcija;
        var kojitip = tip;
        var kojititle = title;
        var kojaakcijaDelete = tablica + "Delete";
        var kontrolerakcijaDelete = kojikontroler + kojaakcijaDelete;
        var kojaPorukaDiv = "Master";

        if(porukaDiv != "Master")
        {
            kojaPorukaDiv = porukaDiv;
        }

        var masterId = $(kojimastergrid).jqGrid('getGridParam', 'selrow');
        var slaveId = $(kojigrid).jqGrid('getGridParam', 'selrow');

        if (kojitip == "Insert") {
            kojititle = kojititle + " UNOS "
        }
        else if (kojitip == "Edit") {
            kojititle = kojititle + " DETALJ "
        }

        // Iniciranje Dialoga
        $(function () {
            $(kojidialog).dialog({
                autoOpen: false,
                show: {
                    effect: "none",
                    duration: 0
                },
                hide: {
                    effect: "none",
                    duration: 0
                },
                width: sirina,
                height: visina,
                modal: true,
                resizable: true,
                position: 'top',
                draggable: true,
                title: kojititle,
                buttons: {

                    Spremi: {
                        text: "Spremi",
                        id: kojidialog + "Spremi",
                        value: "Spremi",
                        click: function () {
                            var frm = kojaforma;
                            var serializeData = $(kojaforma).serialize();

                            if ($(frm).validate().form()) {
                                $.ajax({
                                    url: kontrolerakcija,
                                    data: serializeData,
                                    type: 'POST',
                                    success: function (data) {
                                        if (data.length > 0) {
                                            porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                        }

                                        jQuery(kojigrid).trigger('reloadGrid');
                                        //Ovak dole reload modal dialog je testni, ako se pokaže da ne treba reload može se brisati
                                        //$(kojidialog).load(loader, { Id: slaveId, IdMaster: masterId })
                                    }
                                });
                            }
                        }

                    },

                    Obrisi: {
                        text: "Obriši",
                        id: kojidialog + "Obrisi",
                        value: "Obrisi",

                        click: function () {
                            if (slaveId == null)
                            { alert('Nije odabrana stavka'); }

                            else {
                                if (confirm('Da li sigurno želite obrisati stavku?')) {

                                    var frm = kojaforma;
                                    var serializeData = $(kojaforma).serialize();
                                    $.ajax({
                                        url: kontrolerakcijaDelete,
                                        data: serializeData,
                                        type: 'POST',
                                        success: function (data) {
                                            if (data.length > 0) {
                                                 porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                            }

                                            jQuery(kojigrid).trigger('reloadGrid');

                                        }
                                    });
                                }

                            }

                        }

                    },

                    Zatvori: function () {
                        $(this).dialog("close");
                            $(this).empty();
                    }
                }
            });
        });


        // Otvaranje Forme i Dialoga ovisno o tipu kacije

        if (kojitip == "Insert") {

            if (masterId == null) {
                $.jgrid.viewModal("#alertmod", { gbox: "#gbox_" + kojimastergrid, jqm: true });
                $("#jqg_alrt").focus();
            }
            else {
                slaveId = null
                $(kojidialog).dialog("open").load(loader, { Id: slaveId, IdMaster: masterId })

            }
        }

        else if (kojitip == "Edit") {
            if (slaveId == null) {
                $.jgrid.viewModal("#alertmod", { gbox: "#gbox_" + kojirgrid, jqm: true });
                $("#jqg_alrt").focus();
            }
            else {
                $(kojidialog).dialog("open").load(loader, { Id: slaveId, IdMaster: masterId })

            }
        }
    };

    InsertEditSlaveTreeGrid = function (tablica, grid, mastergrid, kontroler, dialog, tip, sirina, visina, title) {

        var kojidialog = "#" + tablica + "Dialog";
        var kojikontroler = "../" + kontroler + "/";
        var kojigrid = "#" + grid;
        var loader = kojikontroler + dialog + "Detalj/";
        var kojasirina = sirina;
        var kojavisina = visina;
        var kojaforma = "#" + tablica + "Form";
        var kojimastergrid = "#" + mastergrid;
        var kojaakcija = tablica + "Insert";
        var kontrolerakcija = kojikontroler + kojaakcija;
        var kojitip = tip;
        var kojititle = title;
        var kojaakcijaDelete = tablica + "Delete";
        var kontrolerakcijaDelete = kojikontroler + kojaakcijaDelete;

         var idNadredjeni = null;

        var masterId = $(kojimastergrid).jqGrid('getGridParam', 'selrow');
        var slaveId = $(kojigrid).jqGrid('getGridParam', 'selrow');
        //var idNadredjeni = $(kojigrid).jqGrid('getCell', slaveId, 'ID_KriterijStNad');
        idNadredjeni = slaveId;


        if (kojitip == "Insert") {
            kojititle = kojititle + " UNOS "
        }
        else if (kojitip == "Edit") {
            kojititle = kojititle + " DETALJ "
        }

        // Iniciranje Dialoga
        $(function () {
            $(kojidialog).dialog({
                autoOpen: false,
                show: {
                    effect: "none",
                    duration: 0
                },
                hide: {
                    effect: "none",
                    duration: 0
                },
                width: sirina,
                height: visina,
                modal: true,
                resizable: false,
                position: 'top',
                draggable: true,
                title: kojititle,
                buttons: {
                    Spremi: function () {
                        var frm = kojaforma;
                        var serializeData = $(kojaforma).serialize();

                        if ($(frm).validate().form()) {
                            $.ajax({
                                url: kontrolerakcija,
                                data: serializeData,
                                type: 'POST',
                                success: function (data) {
                                    if (data.length > 0) {
                                        porukeIzSkripte.VratiPorukuStatus(data, "Master");
                                    }
                                    jQuery(kojigrid).jqGrid('resetSelection');
                                    jQuery(kojigrid).trigger('reloadGrid');
                                   }
                            });
                        }



                    },

                    Obriši: function () {
                        if (slaveId == null)
                        { alert('Nije odabrana stavka'); }

                        else {
                            if (confirm('Da li sigurno želite obrisati stavku?')) {

                                var frm = kojaforma;
                                var serializeData = $(kojaforma).serialize();
                                $.ajax({
                                    url: kontrolerakcijaDelete,
                                    data: serializeData,
                                    type: 'POST',
                                    success: function (data) {
                                        if (data.length > 0) {
                                            porukeIzSkripte.VratiPorukuStatus(data, "Master");
                                        }

                                        jQuery(kojigrid).trigger('reloadGrid');

                                    }
                                });
                            }

                        }

                    },
                    Zatvori: function () {
                        $(this).dialog("close");
                            $(this).empty();
                    }
                }
            });
        });


        // Otvaranje Forme i Dialoga ovisno o tipu kacije

        if (kojitip == "Insert") {

            if (masterId == null) {
                $.jgrid.viewModal("#alertmod", { gbox: "#gbox_" + kojimastergrid, jqm: true });
                $("#jqg_alrt").focus();
            }
            else {
                slaveId = null
                $(kojidialog).dialog("open").load(loader, { Id: slaveId, IdMaster: masterId, Idnad: idNadredjeni })

            }
        }

        else if (kojitip == "Edit") {
            if (slaveId == null) {
                $.jgrid.viewModal("#alertmod", { gbox: "#gbox_" + kojirgrid, jqm: true });
                $("#jqg_alrt").focus();
            }
            else {
                $(kojidialog).dialog("open").load(loader, { Id: slaveId, IdMaster: masterId, Idnad: idNadredjeni })

            }
        }
    };


    LoadSlaveGrid = function (grid, mastergrid, polje, kontroler, akcija) {

        var kojikontroler = "../" + kontroler + "/";
        var kojigrid = "#" + grid;
        var kojimastergrid = "#" + mastergrid;
        var kojaakcija = akcija + "Grid";
        var kontrolerakcija = kojikontroler + kojaakcija;
        var kojepolje = polje

        var selectedRowId = $(kojimastergrid).jqGrid('getGridParam', 'selrow');

        jQuery(kojigrid).jqGrid('setGridParam', { url: kontrolerakcija, postData: { key: kojepolje, value: selectedRowId} });
        jQuery(kojigrid).trigger('reloadGrid');
    }



    PoslovniSubjekt = function (grid, kontroler, tip) {

        var kojikontroler = "../" + kontroler + "/";
        var kojigrid = "#" + grid;
        var kojimastergrid = "#" + mastergrid;
        var kojaakcija = akcija + "Grid";
        var kontrolerakcija = kojikontroler + kojaakcija;
        var kojepolje = polje

        var selectedRowId = $(kojigrid).jqGrid('getGridParam', 'selrow');
        var selectedRowIdPoslovniSubjekt = $('#kojigrid').jqGrid('getCell', selectedRowId, 'ID_PoslovniSubjekt');

        if (kojitip == "Insert") {
            kojititle = kojititle + " UNOS "
        }
        else if (kojitip == "Edit") {
            kojititle = kojititle + " DETALJ "
        }

        if (selectedRowId == null)
        { alert('Nije odabrana stavka'); }

        else {

            if (selectedRowIdPoslovniSubjekt != null) {

                if (confirm('Osobu maknuti ?')) {

                    var frm = kojaforma;
                    var serializeData = $(kojaforma).serialize();
                    $.ajax({
                        url: kontrolerakcijaDelete,
                        data: serializeData,
                        type: 'POST',
                        success: function (data) {
                            if (data.length > 0) {
                                porukeIzSkripte.VratiPorukuStatus(data, "Master");
                            }

                            jQuery(kojigrid).trigger('reloadGrid');

                        }
                    });
                }
            }
            else {
            }

        }


    }



    DropDownValuta = function (idValuta) {

        if (idValuta != "") {
            $('#ID_ValutaPomoc').val(idValuta).chosen();
        }
        else {
            $('#ID_ValutaPomoc').val("HRK").chosen();
            $("#IDValuta").val("HRK");
        }

    }


    PostaviValuta = function () {

        $("#ID_ValutaPomoc").change(function () {
            var selectVal = $('#ID_ValutaPomoc :selected').val();
            $("#IDValuta").val(selectVal);
        });
    }


    DatePicker = function () {

        $('.datepicker').datepicker({
            startDate: "today",
            orientation: "top right",
            autoclose: true,
            dateFormat: 'dd/mm/yy',
            changeMonth: true,
            changeYear: true,
            selectOtherMonths: true,
            monthNames: ['Siječanj', 'Veljača', 'Ožujak', 'Travanj', 'Svibanj', 'Lipanj', 'Srpanj', 'Kolovoz', 'Rujan', 'Listopad', 'Studeni', 'Prosinac'],
            monthNamesShort: ['Sij', 'Velj', 'Ožu', 'Tra', 'Svi', 'Lip', 'Srp', 'Kol', 'Ruj', 'Lis', 'Stu', 'Pro'],
            dayNames: ['Nedjelja', 'Ponedjeljak', 'Utorak', 'Srijeda', 'Četvrtak', 'Petak', 'Subota'],
            dayNamesShort: ['Ned', 'Pon', 'Uto', 'Sri', 'Čet', 'Pet', 'Sub'],
            dayNamesMin: ['Ne', 'Po', 'Ut', 'Sr', 'Če', 'Pe', 'Su'],
            weekHeader: 'Tjedan',
            constrainInput: false
        })

        $('.datepicker').datepicker().unbind('focus').dblclick(function () {
            $(this).datepicker('show');
        });

    }


    DatumProvjera = function (iDatum) {

        var Dan;
        var Mjesec;
        var Godina;
        var Datum;
        var Faktor;
        var datumReturn;

        Datum = iDatum.replace(new RegExp(" ", "g"), '');
        Datum = Datum.replace(new RegExp("-", "g"), '.');
        Datum = Datum.replace(new RegExp("/", "g"), '.');
        Datum = Datum.replace(new RegExp(",", "g"), '.');
        Datum = Datum.trim();

        Datum = Datum.replace(/0*(\d*)/gi, "$1");

        var dateArray = Datum.split(".");

        Dan = dateArray[0];
        Mjesec = dateArray[1];
        Godina = dateArray[2];


        if ((Dan == "1" && Mjesec == "1" && Godina == "1") || iDatum == "") {
            datumReturn = 0;
        }
        else {
            if (Godina < 100) {
                if (Godina < 30) {
                    Godina = 2000 + parseInt(Godina);
                }
                else {
                    Godina = 1900 + parseInt(Godina);
                }
            }
            else if (Godina < 1000) {
                Godina = 2000 + parseInt(Godina);
            }

            var testDate = new Date(parseInt(Godina), parseInt(Mjesec) - 1, parseInt(Dan));

            if (testDate.getDate() != Dan || (testDate.getMonth() + 1) != Mjesec || testDate.getFullYear() != Godina) 
            {
                datumReturn = 1;

            } else {
                var datum = Dan + "/" + Mjesec + "/" + Godina;
                datumReturn = datum;
            }
        }

        return datumReturn;

    }


    DatumFormat = function (Datum, Format = "HR") {
        var datumFormated;

        var dateArray = Datum.split("/");
        D = dateArray[0];
        M = dateArray[1];
        G = dateArray[2];

        switch (Format) {
            case "HR":
                if (D < 10) {
                    D = "0" + D
                }

                if (M < 10) {
                    M = "0" + M
                }
                datumFormated = D + "." + M + "." + G + ".";
                break;
        }

        return datumFormated;
    }


    PostaviDatumPolje = function (PoljeForma, Datum, Format) 
    {
        var value = Datum;
        var Provjeren = DatumProvjera(value);
        var Polje = "#" + PoljeForma;
        var PoljePomoc = "#" + PoljeForma + "Pomoc";
        var PoljeValmsg = PoljeForma;

        if (Provjeren == 0) 
        {
            $(Polje).val("");
            $(PoljePomoc).val("");
            $(PoljePomoc).addClass("text-box single-line input-validation-error");
            $("[data-valmsg-for='" + PoljeValmsg + "']").show();

        }
        else if (Provjeren == 1)
         {
            $(Polje).val("");
            $(PoljePomoc).val("");
            $(PoljePomoc).addClass("text-box single-line input-validation-error");
            $("[data-valmsg-for='" + PoljeValmsg + "']").show();
        }
        else 
        {
            $(Polje).val(Provjeren);
            var Formatiran = DatumFormat(Provjeren, Format);
            $(PoljePomoc).val(Formatiran);
            $("[data-valmsg-for='" + PoljeValmsg + "']").hide();
            $(PoljePomoc).removeClass("text-box single-line input-validation-error");
        }

    }


       DocumentReadyValid = function (PoljeForma, Validni = 1) {
        var Polje = "#" + PoljeForma;
        var PoljePomoc = "#" + PoljeForma + "Pomoc";

        if (Validni == 1)
        {
            $(PoljePomoc).removeClass("text-box single-line input-validation-error").addClass("text-box single-line valid");
        }
        else
        {
            $(PoljePomoc).removeClass("text-box single-line valid").addClass("text-box single-line input-validation-error");
        }
        
    }


        VaidirajHiddenPolja = function (Forma){
        var kojaforma = "#" + Forma;
        var validator = $(kojaforma).data('validator');
        validator.settings.ignore = [];
    }

       VratiValidator = function (Forma){
        var kojaforma = "#" + Forma;
        var validator = $(kojaforma).data('validator');
        return validator;
    }
     

    return {
        InsertEditMaster: InsertEditMaster,
        InsertEditSlave: InsertEditSlave,
        InsertEditSlaveTreeGrid: InsertEditSlaveTreeGrid,
        LoadSlaveGrid: LoadSlaveGrid,
        PoslovniSubjekt: PoslovniSubjekt,
        DropDownValuta: DropDownValuta,
        PostaviValuta: PostaviValuta,
        DatePicker: DatePicker,
        DatumProvjera: DatumProvjera,
        DatumFormat: DatumFormat,
        PostaviDatumPolje: PostaviDatumPolje,
        DocumentReadyValid: DocumentReadyValid,
        VaidirajHiddenPolja: VaidirajHiddenPolja,
        VratiValidator:VratiValidator
    };

} ();





var Dialozi = function () {

    InsertEditMaster = function (tablica, grid, mastergrid, kontroler, dialog, tip, sirina, visina, title, porukaDiv, masterComboId) {

        var kojidialog = "#" + tablica + "Dialog";
        var kojidialogButton = tablica + "Dialog"
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
        var kojiIdTablice = "ID_" + tablica;
        var kojiIdTabliceSelector = "#" + kojiIdTablice;
        var kojaPorukaDivIsprazni = "#poruka_" + kojaPorukaDiv;

        if (porukaDiv != "" && porukaDiv != undefined) {
            kojaPorukaDiv = porukaDiv;
        }

        if (mastergrid != "") {
            var masterId = $(kojimastergrid).jqGrid('getGridParam', 'selrow');
        }
        else if (mastergrid == "" && masterComboId != "") {
            var masterId = masterComboId;
            var slaveId = masterComboId;

            if (isNaN(masterComboId / 1) == false) {

                var masterId = masterComboId;
                var slaveId = masterComboId;
                alert("je broj" + masterComboId);
            }
            else {
                var selectedRow = $(kojigrid).jqGrid('getGridParam', 'selrow');
                var slaveId = $(kojigrid).jqGrid('getCell', selectedRow, masterComboId);

            }
        }

        else if (mastergrid == "" && masterComboId == "") {
            var slaveId = $(kojigrid).jqGrid('getGridParam', 'selrow');
        }

        var masterId = null;
        //var slaveId = $(kojigrid).jqGrid('getGridParam', 'selrow');


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

                    SpremiKopiraj: {
                        text: "",
                        title: "Spremi i kopiraj IEM",
                        id: kojidialogButton + "SpremiKopiraj",
                        class: 'SpremiKopirajClass',
                        value: "SpremiKopiraj",
                        click: function () {
                            var frm = kojaforma;
                            // Dodano za testiranje za da se na post da se na post pošalju sve vrijednosti i iz disable polja, ako se poikaže da je funkcija dobra staviti je i na InsertEditMaster
                            var disabled = $(kojaforma).find(':input:disabled').removeAttr('disabled');

                            var serializeData = $(kojaforma).serialize();

                            if ($(frm).validate().form()) {
                                $.ajax({
                                    url: kontrolerakcija,
                                    data: serializeData,
                                    type: 'POST',
                                    success: function (data) {
                                        if (data.length > 0) {
                                            porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                            InsertEditError();
                                        }
                                        else {
                                            jQuery(kojigrid).trigger('reloadGrid');
                                            InsertEditSucces();
                                            $(kojaPorukaDivIsprazni).text("");
                                            if ($("#Oznaka").length > 0) {
                                                $("#Oznaka").val("");
                                            }
                                            $(kojiIdTabliceSelector).val("-1");
                                        }
                                    }
                                });
                            }
                        }

                    },

                    SpremiDodaj: {
                        text: "",
                        title: "Spremi i dodaj IEM",
                        id: kojidialogButton + "SpremiDodaj",
                        class: 'SpremiDodajClass',
                        value: "SpremiDodaj",
                        click: function () {
                            var frm = kojaforma;
                            // Dodano za testiranje za da se na post da se na post pošalju sve vrijednosti i iz disable polja, ako se poikaže da je funkcija dobra staviti je i na InsertEditMaster
                            var disabled = $(kojaforma).find(':input:disabled').removeAttr('disabled');

                            var serializeData = $(kojaforma).serialize();
                            if ($(frm).validate().form()) {
                                $.ajax({
                                    url: kontrolerakcija,
                                    data: serializeData,
                                    type: 'POST',
                                    success: function (data) {
                                        if (data.length > 0) {
                                            porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                            InsertEditError();
                                        }
                                        else {
                                            jQuery(kojigrid).trigger('reloadGrid');
                                            InsertEditSucces();
                                            $(kojaPorukaDivIsprazni).text("");
                                            //$(kojidialog).load(loader, { Id: slaveId, IdMaster: masterId })
                                            $(kojidialog).load(loader, { Id: null, IdMaster: masterId })
                                        }
                                    }
                                });
                            }
                        }

                    },

                    Spremi:
                    {
                        text: "",
                        title: "Spremi",
                        id: kojidialogButton + "Spremi",
                        class: 'SpremiClass',
                        value: "Spremi",
                        click: function () {
                            var frm = kojaforma;
                            var disabled = $(kojaforma).find(':input:disabled').removeAttr('disabled');

                            var serializeData = $(kojaforma).serialize();

                            if ($(frm).validate().form()) {
                                $.ajax({
                                    url: kontrolerakcija,
                                    data: serializeData,
                                    type: 'POST',
                                    success: function (data) {
                                        if (data.length > 0) {
                                            porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                            InsertEditError();

                                        }
                                        else {
                                            InsertEditSucces();
                                            $(kojaPorukaDivIsprazni).text("");
                                            $(kojidialog).dialog("close");
                                            $(kojidialog).empty();
                                        }

                                        jQuery(kojigrid).trigger('reloadGrid');


                                    }
                                });
                            }

                        }

                    },

                    Obriši:
                    {
                        text: "",
                        title: "Obriši",
                        id: kojidialogButton + "Obrisi",
                        class: 'ObrisiClass',
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
                                                DeleteError();
                                            }
                                            else {
                                                DeleteSucces();
                                                $(kojidialog).dialog("close");
                                                $(kojidialog).empty();
                                            }

                                            jQuery(kojigrid).trigger('reloadGrid');


                                        }
                                    });
                                }

                            }
                        }
                    },

                    Zatvori:
                    {
                        text: "",
                        title: "Zatvori",
                        class: 'ZatvoriClass',
                        click: function () {
                            $(this).dialog("close");
                            $(this).empty();
                        }
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
                $.jgrid.viewModal("#alertmod", { gbox: "#gbox_" + kojigrid, jqm: true });
                $("#jqg_alrt").focus();

            }
            else {
                $(kojidialog).dialog("open").load(loader, { Id: slaveId, IdMaster: masterId })
            }
        }
    };

    InsertEditSlave = function (tablica, grid, mastergrid, kontroler, dialog, tip, sirina, visina, title, porukaDiv, masterComboId) {

        var kojidialog = "#" + tablica + "Dialog";
        var kojidialogButton = tablica + "Dialog";
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
        var kojiIdTablice = "ID_" + tablica;
        var kojiIdTabliceSelector = "#" + kojiIdTablice;
        var kojaPorukaDivIsprazni = "#poruka_" + kojaPorukaDiv;

        if (porukaDiv != "" && porukaDiv != undefined) {
            kojaPorukaDiv = porukaDiv;
        }

        if (mastergrid != "") {
            var masterId = $(kojimastergrid).jqGrid('getGridParam', 'selrow');
        }
        else if (mastergrid == "" && masterComboId != "") {
            var masterId = masterComboId;
        }

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

                    SpremiKopiraj: {
                        text: "",
                        title: "Spremi i kopiraj",
                        id: kojidialogButton + "SpremiKopiraj",
                        class: 'SpremiKopirajClass',
                        value: "SpremiKopiraj",
                        click: function () {
                            var frm = kojaforma;
                            // Dodano za testiranje za da se na post da se na post pošalju sve vrijednosti i iz disable polja, ako se poikaže da je funkcija dobra staviti je i na InsertEditMaster
                            var disabled = $(kojaforma).find(':input:disabled').removeAttr('disabled');

                            var serializeData = $(kojaforma).serialize();
                            var provjera = ProvjeraKodUnosa();

                            if (provjera == false) {
                                return false;
                            }
                            else {

                                if ($(frm).validate().form()) {
                                    $.ajax({
                                        url: kontrolerakcija,
                                        data: serializeData,
                                        type: 'POST',
                                        success: function (data) {

                                            if (data.length > 0) {
                                                porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                                InsertEditError();
                                            }
                                            else {
                                                jQuery(kojigrid).trigger('reloadGrid');
                                                InsertEditSucces();
                                                $(kojaPorukaDivIsprazni).text("");
                                                if ($("#Oznaka").length > 0) {
                                                    $("#Oznaka").val("");
                                                }
                                                $(kojiIdTabliceSelector).val("-1");

                                            }
                                        }
                                    });
                                }
                            }
                        }

                    },

                    SpremiDodaj: {
                        text: "",
                        title: "Spremi i dodaj",
                        id: kojidialogButton + "SpremiDodaj",
                        class: 'SpremiDodajClass',
                        value: "SpremiDodaj",
                        click: function () {
                            var frm = kojaforma;
                            // Dodano za testiranje za da se na post da se na post pošalju sve vrijednosti i iz disable polja, ako se poikaže da je funkcija dobra staviti je i na InsertEditMaster
                            var disabled = $(kojaforma).find(':input:disabled').removeAttr('disabled');

                            var serializeData = $(kojaforma).serialize();
                            var provjera = ProvjeraKodUnosa();

                            if (provjera == false) {
                                return false;
                            }
                            else {

                                if ($(frm).validate().form()) {
                                    $.ajax({
                                        url: kontrolerakcija,
                                        data: serializeData,
                                        type: 'POST',
                                        success: function (data) {
                                            if (data.length > 0) {
                                                porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                                InsertEditError();
                                            }
                                            else {
                                                jQuery(kojigrid).trigger('reloadGrid');
                                                InsertEditSucces();
                                                $(kojaPorukaDivIsprazni).text("");
                                                //$(kojidialog).load(loader, { Id: slaveId, IdMaster: masterId })
                                                $(kojidialog).load(loader, { Id: null, IdMaster: masterId })
                                            }
                                        }
                                    });
                                }
                            }
                        }

                    },

                    Spremi: {
                        text: "",
                        title: "Spremi",
                        id: kojidialogButton + "Spremi",
                        class: 'SpremiClass',
                        value: "Spremi",
                        click: function () {
                            var frm = kojaforma;
                            // Dodano za testiranje za da se na post da se na post pošalju sve vrijednosti i iz disable polja, ako se poikaže da je funkcija dobra staviti je i na InsertEditMaster
                            var disabled = $(kojaforma).find(':input:disabled').removeAttr('disabled');

                            var serializeData = $(kojaforma).serialize();
                            var provjera = ProvjeraKodUnosa();

                            if (provjera == false) {
                                return false;
                            }
                            else {

                                if ($(frm).validate().form()) {
                                    $.ajax({
                                        url: kontrolerakcija,
                                        data: serializeData,
                                        type: 'POST',
                                        success: function (data) {
                                            if (data.length > 0) {
                                                porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                                InsertEditError();
                                            }
                                            else {
                                                jQuery(kojigrid).trigger('reloadGrid');
                                                InsertEditSucces();
                                                $(kojaPorukaDivIsprazni).text("");
                                                $(kojidialog).dialog("close");
                                                $(kojidialog).empty();
                                            }
                                            //                                        jQuery(kojigrid).trigger('reloadGrid');
                                            //Ovak dole reload modal dialog je testni, ako se pokaže da ne treba reload može se brisati
                                            //$(kojidialog).load(loader, { Id: slaveId, IdMaster: masterId })


                                        }
                                    });
                                }
                            }
                        }

                    },

                    Obrisi: {
                        text: "",
                        title: "Obriši",
                        id: kojidialogButton + "Obrisi",
                        class: 'ObrisiClass',
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
                                                DeleteError();
                                            }
                                            else {
                                                jQuery(kojigrid).trigger('reloadGrid');
                                                DeleteSucces();
                                                $(kojidialog).dialog("close");
                                                $(kojidialog).empty();
                                            }

                                            // jQuery(kojigrid).trigger('reloadGrid');

                                        }
                                    });
                                }

                            }

                        }

                    },

                    //                    Zatvori: function () {
                    //                        $(this).dialog("close");
                    //                        $(this).empty();
                    //                    }

                    Zatvori:
                    {
                        text: "",
                        title: "Zatvori",
                        class: 'ZatvoriClass',
                        click: function () {
                            $(this).dialog("close");
                            $(this).empty();
                        }
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
                $.jgrid.viewModal("#alertmod", { gbox: "#gbox_" + kojigrid, jqm: true });
                $("#jqg_alrt").focus();
            }
            else {
                $(kojidialog).dialog("open").load(loader, { Id: slaveId, IdMaster: masterId })

            }


            //            $(kojidialog).dialog("open").load(loader, { Id: slaveId, IdMaster: masterId })
        }
    };

    InsertEditSlaveTreeGrid = function (tablica, grid, mastergrid, kontroler, dialog, tip, sirina, visina, title, porukaDiv) {

        var kojidialog = "#" + tablica + "Dialog";
        var kojidialogButton = tablica + "Dialog";
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

        if (porukaDiv != "" && porukaDiv != undefined) {
            kojaPorukaDiv = porukaDiv;
        }

        var kojiIdTabliceSelector = "#ID_KriterijSt";
        var kojaPorukaDivIsprazni = "#poruka_" + kojaPorukaDiv;


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


                    SpremiKopiraj: {
                        text: "",
                        title: "Spremi i kopiraj",
                        id: kojidialogButton + "SpremiKopiraj",
                        class: 'SpremiKopirajClass',
                        value: "SpremiKopiraj",
                        click: function () {
                            var frm = kojaforma;
                            // Dodano za testiranje za da se na post da se na post pošalju sve vrijednosti i iz disable polja, ako se poikaže da je funkcija dobra staviti je i na InsertEditMaster
                            var disabled = $(kojaforma).find(':input:disabled').removeAttr('disabled');

                            var serializeData = $(kojaforma).serialize();

                            if ($(frm).validate().form()) {
                                $.ajax({
                                    url: kontrolerakcija,
                                    data: serializeData,
                                    type: 'POST',
                                    success: function (data) {
                                        if (data.length > 0) {
                                            porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                            InsertEditError();
                                        }
                                        else {
                                            jQuery(kojigrid).trigger('reloadGrid');
                                            InsertEditSucces();
                                            $(kojaPorukaDivIsprazni).text("");
                                            if ($("#Oznaka").length > 0) {
                                                $("#Oznaka").val("");
                                            }

                                            //$(kojiIdTabliceSelector).val("-1");
                                        }
                                    }
                                });
                            }
                        }

                    },

                    SpremiDodaj: {
                        text: "",
                        title: "Spremi i dodaj",
                        id: kojidialogButton + "SpremiDodaj",
                        class: 'SpremiDodajClass',
                        value: "SpremiDodaj",
                        click: function () {
                            var frm = kojaforma;
                            // Dodano za testiranje za da se na post da se na post pošalju sve vrijednosti i iz disable polja, ako se poikaže da je funkcija dobra staviti je i na InsertEditMaster
                            var disabled = $(kojaforma).find(':input:disabled').removeAttr('disabled');

                            var serializeData = $(kojaforma).serialize();
                            if ($(frm).validate().form()) {
                                $.ajax({
                                    url: kontrolerakcija,
                                    data: serializeData,
                                    type: 'POST',
                                    success: function (data) {
                                        if (data.length > 0) {
                                            porukeIzSkripte.VratiPorukuStatus(data, kojaPorukaDiv);
                                            InsertEditError();
                                        }
                                        else {
                                            jQuery(kojigrid).jqGrid('resetSelection');
                                            jQuery(kojigrid).trigger('reloadGrid');
                                            InsertEditSucces();
                                            $(kojaPorukaDivIsprazni).val("");
                                            $(kojidialog).load(loader, { Id: slaveId, IdMaster: masterId })
                                        }
                                    }
                                });
                            }
                        }

                    },

                    Spremi:
                    {
                        text: "",
                        title: "Spremi",
                        id: kojidialogButton + "Spremi",
                        class: 'SpremiClass',
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
                                            alert(kojaPorukaDiv);
                                            InsertEditError();
                                        }
                                        else {
                                            jQuery(kojigrid).jqGrid('resetSelection');
                                            jQuery(kojigrid).trigger('reloadGrid');
                                            InsertEditSucces();
                                            $(kojaPorukaDivIsprazni).val("");
                                            $(kojidialog).dialog("close");
                                            $(kojidialog).empty();
                                        }

                                    }
                                });
                            }
                        }
                    },

                    Obrisi: {
                        text: "",
                        title: "Obriši",
                        id: kojidialogButton + "Obrisi",
                        class: 'ObrisiClass',
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
                                                porukeIzSkripte.VratiPorukuStatus(data, "Master");
                                            }
                                            else {
                                                $(kojidialog).dialog("close");
                                                $(kojidialog).empty();
                                            }

                                            jQuery(kojigrid).trigger('reloadGrid');


                                        }
                                    });
                                }

                            }
                        }
                    },

                    Zatvori:
                    {
                        text: "",
                        title: "Zatvori",
                        class: 'ZatvoriClass',
                        click: function () {
                            $(this).dialog("close");
                            $(this).empty();
                        }
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
                $.jgrid.viewModal("#alertmod", { gbox: "#gbox_" + kojigrid, jqm: true });
                $("#jqg_alrt").focus();
            }
            else {
                $(kojidialog).dialog("open").load(loader, { Id: slaveId, IdMaster: masterId, Idnad: idNadredjeni })

            }
        }
    };

    LoadSlaveGrid = function (grid, mastergrid, polje, kontroler, akcija, poljewhere) {

        var kojikontroler = "../" + kontroler + "/";
        var kojigrid = "#" + grid;
        var kojimastergrid = "#" + mastergrid;
        var kojaakcija = akcija + "Grid";
        var kontrolerakcija = kojikontroler + kojaakcija;
        var kojepolje = polje;
        var kojepoljewhere = poljewhere;

        if (poljewhere != "" && poljewhere != undefined) {
            var selectedRow = $(kojimastergrid).jqGrid('getGridParam', 'selrow');
            var selectedRowId = $(kojimastergrid).jqGrid('getCell', selectedRow, kojepoljewhere);
        }
        else {

            var selectedRowId = $(kojimastergrid).jqGrid('getGridParam', 'selrow');
        }



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

    $(".btnDropDownSymbol").click(function () {
        $(this).val(" ");
        $(this).trigger('keydown');

    });

    ComboAll = function () {

        $(this).val(" ");
        $(this).trigger('keydown');
    }

    DropDownValuta = function (idValuta) {

        //        if (idValuta != "") {
        //            $('#ID_ValutaPomoc').val(idValuta).chosen();
        //        }
        //        else {
        //            $('#ID_ValutaPomoc').val("HRK").chosen();
        //            $("#IDValuta").val("HRK");
        //        }

        if (idValuta != "") {
            $('#ID_ValutaPomoc').val(idValuta);
        }
        else {
            $('#ID_ValutaPomoc').val("HRK");
            $("#IDValuta").val("HRK");
        }

    }

    DropDownValutaSaPrefix = function (prefix, idValuta) {

        var ImeElemnta = "#" + prefix + "ID_ValutaPomoc";
        if (idValuta != "") {
            $(ImeElemnta).val(idValuta).chosen();
        }
        else {
            $(ImeElemnta).val("HRK").chosen();
            $("#IDValuta").val("HRK");
        }



    }

    PostaviValuta = function () {

        $("#ID_ValutaPomoc").change(function () {
            var selectVal = $('#ID_ValutaPomoc :selected').val();
            $("#IDValuta").val(selectVal);
        });
    }

    PostaviPoljeVrijednost = function (idPolje, idVrijednost) {

        $(idPolje).val(idVrijednost);
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
            constrainInput: false,
            yearRange: '-100:+11'
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

            if (testDate.getDate() != Dan || (testDate.getMonth() + 1) != Mjesec || testDate.getFullYear() != Godina) {
                datumReturn = 1;

            } else {
                var datum = Dan + "/" + Mjesec + "/" + Godina;
                datumReturn = datum;
            }
        }

        return datumReturn;

    }

    DatumFormat = function (Datum, Format) {


        var datumFormated;
        var kojiFormat = "HR";

        var dateArray = Datum.split("/");
        D = dateArray[0];
        M = dateArray[1];
        G = dateArray[2];


        if (Format != undefined) {
            kojiFormat = Format;
        }

        switch (kojiFormat) {
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

    PostaviDatumPolje = function (PoljeForma, Datum, Format) {

        var value = Datum;
        var Provjeren = DatumProvjera(value);
        var Polje = "#" + PoljeForma;
        var PoljePomoc = "#" + PoljeForma + "Pomoc";
        var PoljeValmsg = PoljeForma;

        if (Provjeren == 0) {
            $(Polje).val("");
            $(PoljePomoc).val("");
            $(PoljePomoc).addClass("text-box single-line input-validation-error");
            $("[data-valmsg-for='" + PoljeValmsg + "']").show();

        }
        else if (Provjeren == 1) {
            $(Polje).val("");
            $(PoljePomoc).val("");
            $(PoljePomoc).addClass("text-box single-line input-validation-error");
            $("[data-valmsg-for='" + PoljeValmsg + "']").show();
        }
        else {
            $(Polje).val(Provjeren);
            var Formatiran = DatumFormat(Provjeren, Format);
            $(PoljePomoc).val(Formatiran);
            $("[data-valmsg-for='" + PoljeValmsg + "']").hide();
            $(PoljePomoc).removeClass("text-box single-line input-validation-error");
        }

    }

    PostaviDatumPoljePrefix = function (Prefix, PoljeForma, Datum, Format) {

        var value = Datum;
        var Provjeren = DatumProvjera(value);
        var Polje = "#" + PoljeForma;
        var PoljePomoc = "#" + Prefix + PoljeForma + "Pomoc";
        var PoljeValmsg = PoljeForma;

        if (Provjeren == 0) {
            $(Polje).val("");
            $(PoljePomoc).val("");
            $(PoljePomoc).addClass("text-box single-line input-validation-error");
            $("[data-valmsg-for='" + PoljeValmsg + "']").show();

        }
        else if (Provjeren == 1) {
            $(Polje).val("");
            $(PoljePomoc).val("");
            $(PoljePomoc).addClass("text-box single-line input-validation-error");
            $("[data-valmsg-for='" + PoljeValmsg + "']").show();
        }
        else {
            $(Polje).val(Provjeren);
            var Formatiran = DatumFormat(Provjeren, Format);
            $(PoljePomoc).val(Formatiran);
            $("[data-valmsg-for='" + PoljeValmsg + "']").hide();
            $(PoljePomoc).removeClass("text-box single-line input-validation-error");
        }

    }

    DocumentReadyValid = function (PoljeForma, Validni) {

        var Polje = "#" + PoljeForma;
        var PoljePomoc = "#" + PoljeForma + "Pomoc";
        var kojiValidni = 1;

        if (Validni != undefined) {
            kojiValidni = Validni;
        }

        if (kojiValidni == 1) {
            $(PoljePomoc).removeClass("text-box single-line input-validation-error").addClass("text-box single-line valid");
        }
        else {
            $(PoljePomoc).removeClass("text-box single-line valid").addClass("text-box single-line input-validation-error");
        }
    }

    VaidirajHiddenPolja = function (Forma) {
        var kojaforma = "#" + Forma;
        var validator = $(kojaforma).data('validator');
        validator.settings.ignore = [];
    }

    VratiValidator = function (Forma) {
        var kojaforma = "#" + Forma;
        var validator = $(kojaforma).data('validator');
        return validator;
    }

    DeleteIzGrida = function (tablica, grid, kontroler, porukaDiv) {

        var kojikontroler = "../" + kontroler + "/";
        var kojigrid = "#" + grid;
        var kojaakcijaDelete = tablica + "Delete";
        var kontrolerakcijaDelete = kojikontroler + kojaakcijaDelete;
        var kojaPorukaDiv = "Master";

        if (porukaDiv != "" && porukaDiv != undefined) {
            kojaPorukaDiv = porukaDiv;
        }


        var selectedRowId = $(kojigrid).jqGrid('getGridParam', 'selrow');
        var grid_id = kojigrid;

        if (selectedRowId == null) {
            $.jgrid.viewModal("#alertmod", { gbox: "#gbox_" + grid_id, jqm: true });
            $("#jqg_alrt").focus();
        } else {

            if (confirm('Da li sigurno želite obrisati stavku?')) {
                $.ajax({
                    type: 'POST',
                    url: kontrolerakcijaDelete,
                    dataType: 'json',
                    data: { id: selectedRowId },
                    success: function (data) {

                        if (data.length > 0) {
                            porukeIzSkripte.AlertPorukuStatus(data, kojaPorukaDiv);
                        }
                        else {
                            jQuery(kojigrid).trigger('reloadGrid');
                        }

                    }

                });

            }
        }


    };

    DeleteIzTreeViewGrida = function (tablica, grid, kontroler, nadredjenoPolje, porukaDiv) {

        var kojikontroler = "../" + kontroler + "/";
        var kojigrid = "#" + grid;
        var kojaakcijaDelete = tablica + "Delete";
        var kontrolerakcijaDelete = kojikontroler + kojaakcijaDelete;
        var kojaPorukaDiv = "Master";

        if (porukaDiv != "" && porukaDiv != undefined) {
            kojaPorukaDiv = porukaDiv;
        }


        var selectedRowId = $(kojigrid).jqGrid('getGridParam', 'selrow');
        //var selectedRowIdNad = jQuery(kojigrid).jqGrid('getRowData', selectedRowId);
        var selectedRowIdNad = $(kojigrid).jqGrid('getCell', selectedRowId, nadredjenoPolje);
        var grid_id = kojigrid;

        if (selectedRowId == null) {
            $.jgrid.viewModal("#alertmod", { gbox: "#gbox_" + grid_id, jqm: true });
            $("#jqg_alrt").focus();
        } else {

            if (confirm('Da li sigurno želite obrisati stavku?')) {
                $.ajax({
                    type: 'POST',
                    url: kontrolerakcijaDelete,
                    dataType: 'json',
                    data: { id: selectedRowId, idTablicaPutNivo: selectedRowIdNad },
                    success: function (data) {

                        if (data.length > 0) {
                            porukeIzSkripte.AlertPorukuStatus(data, kojaPorukaDiv);
                        }
                        else {
                            jQuery(kojigrid).jqGrid('resetSelection');
                            jQuery(kojigrid).trigger('reloadGrid');
                        }

                    }

                });

            }
        }


    };

    DecimalFunkcija = function (BROJ) {
        if (!BROJ.match(/[a-zA-ZšđčćžŠĐČĆŽ]/g)) {
            var count = BROJ.split(",").length - 1;

            if (count < 2) {
                BROJ = BROJ.replace(/ /g, '');
                BROJ = BROJ.replace(/\./g, '');

                if (count == 0) {
                    BROJ += ',00';
                };

                if (count == 1) {
                    var posljeZareza = BROJ.substr(BROJ.indexOf(',') + 1);
                    if (posljeZareza.length == 0) {
                        BROJ += '00';
                    };
                    if (posljeZareza.length == 1) {
                        BROJ += '0';
                    };
                    if (posljeZareza.length > 2) {
                        BROJ = BROJ.replace(/\,/g, '.');
                        var ZAOKRUZENO = parseFloat(BROJ).toFixed(2);
                        BROJ = ZAOKRUZENO.toString();
                        BROJ = BROJ.replace(/\./g, ',');
                    };
                };
                var parts = BROJ.split(',');
                var part1 = parts[0].replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1.");
                var part2 = parts[1];

                BROJ = part1 + ',' + part2;
            };
        };

        return BROJ;
    }

    DecimalFunkcija6 = function (BROJ) {
        if (!BROJ.match(/[a-zA-ZšđčćžŠĐČĆŽ]/g)) {
            var count = BROJ.split(",").length - 1;

            if (count < 2) {
                BROJ = BROJ.replace(/ /g, '');
                BROJ = BROJ.replace(/\./g, '');

                if (count == 0) {
                    BROJ += ',000000';
                };

                if (count == 1) {
                    var posljeZareza = BROJ.substr(BROJ.indexOf(',') + 1);
                    if (posljeZareza.length == 0) {
                        BROJ += '000000';
                    };
                    if (posljeZareza.length == 1) {
                        BROJ += '0';
                    };
                    if (posljeZareza.length > 2) {
                        BROJ = BROJ.replace(/\,/g, '.');
                        var ZAOKRUZENO = parseFloat(BROJ).toFixed(6);
                        BROJ = ZAOKRUZENO.toString();
                        BROJ = BROJ.replace(/\./g, ',');
                    };
                };
                var parts = BROJ.split(',');
                var part1 = parts[0].replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1.");
                var part2 = parts[1];

                BROJ = part1 + ',' + part2;
            };
        };

        return BROJ;
    }



    return {
        InsertEditMaster: InsertEditMaster,
        InsertEditSlave: InsertEditSlave,
        InsertEditSlaveTreeGrid: InsertEditSlaveTreeGrid,
        LoadSlaveGrid: LoadSlaveGrid,
        PoslovniSubjekt: PoslovniSubjekt,
        DropDownValuta: DropDownValuta,
        DropDownValutaSaPrefix: DropDownValutaSaPrefix,
        PostaviValuta: PostaviValuta,
        DatePicker: DatePicker,
        DatumProvjera: DatumProvjera,
        DatumFormat: DatumFormat,
        PostaviDatumPolje: PostaviDatumPolje,
        PostaviDatumPoljePrefix: PostaviDatumPoljePrefix,
        DocumentReadyValid: DocumentReadyValid,
        VaidirajHiddenPolja: VaidirajHiddenPolja,
        VratiValidator: VratiValidator,
        ComboAll: ComboAll,
        DeleteIzGrida: DeleteIzGrida,
        DeleteIzTreeViewGrida: DeleteIzTreeViewGrida,
        DecimalFunkcija: DecimalFunkcija,
        DecimalFunkcija6: DecimalFunkcija6
    };

} ();




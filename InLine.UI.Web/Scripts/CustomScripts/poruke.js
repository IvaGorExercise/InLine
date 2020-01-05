
var porukeIzSkripte = function () {

    VratiPoruku = function (data, name) {

        var kojdiv = "#poruka_";
        jQuery(kojdiv + name).show();
        $(kojdiv + name).text("");

        if (data.length != 0) {
            for (var i = 0; i < data.length; i++) {
                var str = data[i];
                var indeks = str.indexOf("_");
                var status = str.substring(indeks - 1, 1);
                var duzinaporuke = data[i].length;
                var pravaporuka = str.substring(duzinaporuke, 2);

                // status 1 = Greska
                if (status == "1") {

                    $(kojdiv + name).append('<span class="red">' + pravaporuka);
                    $(kojdiv + name).append("<br />");

                }

                // status 2 = Upozorenje
                else if (status == "2") {
                    $(kojdiv + name).append('<span class="yellow">' + pravaporuka);
                    $(kojdiv + name).append("<br />");

                }

                // status 3 = Informacija
                else if (status == "3") {
                    $(kojdiv + name).append('<span class="blue">' + pravaporuka);
                    $(kojdiv + name).append("<br />");

                }

                else if (indeks == -1) {
                    //                   var porukabezstatusa = str.substring(duzinaporuke, 1);
                    $(kojdiv + name).append('<span class="blue">' + data);
                    $(kojdiv + name).append("<br />");
                }

            }
        }
        else {

            $(kojdiv + name).append('<span class="green">' + "Akcija uspješno izvršena");
            $(kojdiv + name).append("<br />");

        }

    };

    VratiPorukuStatus = function (data, name) {

        var kojdiv = "#poruka_";
        jQuery(kojdiv + name).show();
        $(kojdiv + name).text("");

        if (data.length > 0) {
            for (var i = 0; i < data.length; i++) {
                var item = data[i];
                var status = item.StatusTekst;
                var poruka = item.PorukaTekst;
                // var savezOption = new Option(item.Name, item.Id);

                if (status == "1") {

                    $(kojdiv + name).append('<span class="red">' + poruka);
                    $(kojdiv + name).append("<br />");

                }

                // status 2 = Upozorenje
                else if (status == "2") {
                    $(kojdiv + name).append('<span class="yellow">' + poruka);
                    $(kojdiv + name).append("<br />");

                }

                // status 3 = Informacija
                else if (status == "3") {
                    $(kojdiv + name).append('<span class="blue">' + poruka);
                    $(kojdiv + name).append("<br />");

                }

                else if (status == "") {
                    //  var porukabezstatusa = str.substring(duzinaporuke, 1);
                    $(kojdiv + name).append('<span class="blue">' + poruka);
                    $(kojdiv + name).append("<br />");
                }

                else if (status == null) {
                    //  var porukabezstatusa = str.substring(duzinaporuke, 1);
                    $(kojdiv + name).append('<span class="blue">' + poruka);
                    $(kojdiv + name).append("<br />");
                }
            }

        }
        else {

            $(kojdiv + name).append('<span class="green">' + "Akcija uspješno izvršena");
            $(kojdiv + name).append("<br />");

        }

    };


    AlertPorukuStatus = function (data, name) {

        var kojdiv = "#poruka_";
        jQuery(kojdiv + name).show();
        $(kojdiv + name).text("");

        if (data.length > 0) {
            for (var i = 0; i < data.length; i++) {
                var item = data[i];
                var status = item.StatusTekst;
                var poruka = item.PorukaTekst;
                // var savezOption = new Option(item.Name, item.Id);
                alert(poruka);
            }

        }
        else {

            $(kojdiv + name).append('<span class="green">' + "Akcija uspješno izvršena");
            $(kojdiv + name).append("<br />");

        }

    };

    return {
        VratiPoruku: VratiPoruku,
        VratiPorukuStatus: VratiPorukuStatus,
        AlertPorukuStatus: AlertPorukuStatus
    };

} ();


$(document).ready(function () {
    $.ajax({
        url: "http://localhost:50961/api/History/GetHistoryByMonasteryID/" + window.localStorage.getItem("MonansteryId"),
        type: "GET",
        contentType: "application/json",
        success: function (list) {
            var html = "";

            for (var i = 0; i < list.length; i++) {
                html = html + "<div class=\"row\">" +
                    "<div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\">" +
                    "<img src=\"../Images/" + list[i].Img + "\" class=\"img-thumbnail img-responsive\">" +
                    "<h3 class=\"help-block\">" +
                    list[i].Description +
                    "</h3>" +
                    "</div>" +
                    "<div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\">" +
                    "<h3>" +
                    "<b>" +
                    list[i].Title +
                    "</b>" +
                    "</h3>" +
                    "<ul>";

                for (var j = 0; j < list[i].Contents.length; j++) {
                    html = html + "<li>" +
                        "<h3>" +
                        list[i].Contents[j] +
                        "</h3>" +
                        "</li>";
                }

                html = html + "</ul>" +
                    "</div>" +
                    "</div>";
            } // end for

            $("#HistoryParagraphs").append(html);
            getPlaces();
        }
    });
});

function getPlaces() {
    $.ajax({
        url: "http://localhost:50961/api/Places/GetPlacesByMonasteryID/" + window.localStorage.getItem("MonansteryId"),
        type: "GET",
        contentType: "application/json",
        success: function (list) {
            $("#HistoryParagraphs").append(
                "<h3>" +
                "<b>" +
                " الأماكن التي بداخل الدير " +
                "</b>" +
                "</h3>" 
            );
            for (var i = 0; i < list.length; i++) {
                $("#HistoryParagraphs").append(
                    "<div class=\"row\">" +
                    "<div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\" >" +
                    "<img src=\"../Images/" + list[i].Image + "\" class=\"img-thumbnail img-responsive\">" +
                    "<h3 class=\"help-block\">" +
                    list[i].ImageDescription +
                    "</h3>" +
                    "</div>" +
                    "<div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\">" +
                    "<h3>" +
                    "<b>" +
                    list[i].Name +
                    "</b>" +
                    "</h3>" +
                    "<ul>" +
                    "<li>" +
                    "<h3>" +
                    list[i].PlaceContent +
                    "</h3>" +
                    "</li>" +
                    "</ul>" +
                    "</div>" +
                    "</div>"
                );
            }
        }
    });
}

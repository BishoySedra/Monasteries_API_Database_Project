$(document).ready(function () {
    $.ajax({
        url: "http://localhost:50961/api/Location/GetLocationByMonasteryID/" + window.localStorage.getItem("MonansteryId"),
        type: "GET",
        contentType: "application/json",
        success: function (location) {
            $("#ContentOfPage").append(
                "<h3 class=\"help-block\">" +
                "<b>" +
                location.NameOfMonastery  +     
                "</b>" +
                "</h3>" +
                "<div class=\"embed-responsive embed-responsive-16by9\">" +
                "<iframe src=\"" + location.LinkOfLocation + "\" width = \"600\" height = \"450\" frameborder = \"0\" style = \border:0\" allowfullscreen >" +
                "</iframe>" +
                "</div>" +
                "<br>" + 
                "<a href=\"#\" class=\"btn btn-primary\">" +
                "<h4>" +
                "كيفية الذهاب" +
               "</h4>" +
               "</a>" +
               "<div style=\"display: none;\" id=\"Mydiv\">" +
               "<h3>" +
               "<b>" +
                     location.HowToGoText + 
               "</b>" +
               "</h3>" +
               "</div>" 
                    );
        }
    });
});

$("#ContentOfPage").on("click", ".btn", function (e) {
    e.preventDefault();
    $('#Mydiv').fadeIn();
});
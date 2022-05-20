$(document).ready(function () {
    $.ajax({
        url: "http://localhost:50961/api/fathersIntro/GetFathersByMonasteryID/1",
        type: "GET",
        contenttype: "application/json",
        success: function (introduction) {
            $("#intro").prepend(
                "<h3 style=\"text-align: center;\" class=\"help-block\">" +
                "<b>" +
                introduction.TitleOfPage +
                "</b>" +
                "</h3>" +
                "<div class=\"row\">" +
                "<div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">" +
                "<h3>" +
                "<b>" +
                introduction.IntroText +
                "</b>" +
                "</h3>" +
                "</div>" +
                "</div>"
            );
        }
    });
});
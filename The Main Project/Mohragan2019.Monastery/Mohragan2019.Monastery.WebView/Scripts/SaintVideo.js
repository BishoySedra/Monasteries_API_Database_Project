$(document).ready(function () {
    $.ajax({
        url: "http://localhost:50961/api/SaintVideo/GetSaintByMonasteryId/" + window.localStorage.getItem("MonansteryId"),
        type: "GET",
        contenttype: "application/json",
        success: function (video) {
            $("#VideoArea").append(
                "<div class=\"row\">" +
                "<div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\">" +
                "<div class=\"embed-responsive embed-responsive-16by9\" style=\"border-radius:20px;\">" +
                "<iframe width=\"560\" height=\"315\" src=\"" + video.VideoLink + "" + "frameborder\"=\"0\" allow = \"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen>" +
                "</iframe>" +
                "</div>" +
                "<br>" +
                "<h3 class=\"help-block\">" +
                video.VideoDescription +
                "</h3>" +
                "</div>" +
                "</div>"
            );
        }
    });
});


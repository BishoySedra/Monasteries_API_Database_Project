$(document).ready(function () {
    $.ajax({
        url: "http://localhost:50961/api/Videos/GetVideosByMonasteryID/" + window.localStorage.getItem("MonansteryId"),
        type: "GET",
        contenttype: "application/json",
        success: 
            function (page) {
                for (var i = 0; i < page.Videos.length; i++) {
                    $("#MonasteryVideos2").append(
                        "<div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\">" +
                        "<br>" +
                        "<br>" +
                        "<p class= \"help-block\">" +
                        page.Videos[i].VideoDescription +
                        "</p>" +
                        "<div class=\"embed-responsive embed-responsive-4by3\">" +
                        "<iframe style=\"border-radius: 12px;\" class=\"embed-responsive-item help-block\" src=\"" + page.Videos[i].VideoLink + "\" frameborder=\"0\"allow=\"autoplay; encrypted-media\" allowfullscreen>" +
                        "</iframe>" +
                        "</div>" +
                        "</div>"
                    );
                }

                $("#MonasteryVideos1").prepend(
                    "<h3 style=\"text-align: center;\">" +
                    "<b>" +
                    page.MonasteryName +
                    "</b>" +
                    "</h3>");
        }
    });
});
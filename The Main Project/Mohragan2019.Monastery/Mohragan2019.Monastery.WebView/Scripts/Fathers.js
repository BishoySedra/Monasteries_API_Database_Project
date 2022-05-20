$(document).ready(function () {
    $.ajax({
        url: "http://localhost:50961/api/fathers/GetFathersByMonasteryID/" + window.localStorage.getItem("MonansteryId"),
        type: "GET",
        contenttype: "application/json",
        success: function (list) {
            var html = "<div class=\"row\">";

            for (var i = 0; i < list.length; i++) {

                if (i > 0 && i % 2 === 0) {
                    html = html + "</div><div class=\"row\">";
                }

                html = html + "<div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\"><div class=\"thumbnail\">" +
                    "<img src=\"../Images/" + list[i].Image + "\" class=\"img-responsive\">" +
                    "<div class=\"caption\">" +
                    "<h4>" +
                    "<b>" +
                    list[i].Name +
                    "</b>" +
                    "</h4>" +
                    "<div class=\"text-center\">" +
                    "<a href=\"#\" class=\"btn btn-lg btn-primary text-center\" data-toggle=\"modal\" data-target=\"#largeModal"+i+"\">" +
                    "<b style=\"font-size: 90%;\">قصة حياته المقدسة" +
                    "</b>" +
                    "</a>" +
                    "</div>" +
                    "</div>" +
                    "</div>";

                html = html + "<div class=\"modal fade\" id=\"largeModal"+i+"\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"largeModal\"  aria-hidden=\"true\">" +
                    "<div class=\"modal-dialog modal-lg\">" +
                    "<div class=\"modal-content\">" +
                    "<div class=\"modal-header\">" +
                    "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\" style=\"float: left;\">&times;" +
                    "</button>" +
                    "<h3 class=\"modal-title\" id=\"myModalLabel\" style=\"text-align:center;\">" +
                    list[i].MainStoryTitle +
                    "</h3>" +
                    "</div>" +
                    "<div class=\"modal-body\">";

                for (var j = 0; j < list[i].StoryTitles.length; j++) {
                    html = html +
                        "<h3 style = \"text-align: center;\">" +
                        "<b>" +
                        list[i].StoryTitles[j].Title +
                        "</b>" +
                        "</h3><ul>";

                    for (var x = 0; x < list[i].StoryTitles[j].Paragraphs.length; x++) {
                        html = html + "<li><h3>" + list[i].StoryTitles[j].Paragraphs[x] + "</h3></li>";
                    }

                    html = html + "</ul>";
                }

                html = html +
                    "</div>" +
                    "<div class=\"modal-footer\">" +
                    "<div class=\"text-center\">" +
                    "<button type=\"button\" class=\"btn btn-danger\" data-dismiss=\"modal\">" +
                    "<b style=\"font-size: 90%;\">اغلاق</b>" +
                    "</button></div></div></div></div></div></div>";
            }

            $("#card").append(html);
        }
    });
});
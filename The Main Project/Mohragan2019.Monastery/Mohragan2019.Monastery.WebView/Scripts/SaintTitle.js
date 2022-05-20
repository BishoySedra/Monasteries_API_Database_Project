$(document).ready(function () {
    $.ajax({
        url: "http://localhost:50961/api/SaintTitle/GetSaintByMonasteryID/" + window.localStorage.getItem("MonansteryId"),
        type: "GET",
        contenttype: "application/json",
        success: function (list) {

            var html = "";
            html = html +
                "<div class=\"row\">" +
                "<div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\">" +
                "<img src=\"../Images/antonios.jpg\" class=\"img-thumbnail img-responsive\">" +
                "</div>" +
                "<div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\">" +
                "<h3>" +
                "<b>" +
                list[0].Title +
                "</b>" +
                "</h3>" +
                "<ul>";


            for (var i = 0; i < list[0].Paragraphs.length; i++) {
                html = html +
                    "<li>" +
                    "<h3>" +
                    list[0].Paragraphs[i] +
                    "</h3>" +
                    "</li>";
            }

            html = html + "</ul></div></div>";

            for (var y = 1; y < list.length; y++) {
                html = html +
                    "<div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\">" +
                    "<div class=\"hidden-sm hidden-xs jumbotron\" style=\"background-color: #d4d1d1; border-radius: 10%;\">" +
                    "<h3 style=\"text-align: center;\">" +
                    "<b>" +
                    list[y].Title +
                    "</b>" +
                    "</h3>" +
                    "<ul>";

                for (var j = 0; j < list[y].Paragraphs.length; j++) {
                    html = html +
                        "<li>" +
                        "<h3>" +
                        list[y].Paragraphs[j] +
                        "</h3>" +
                        "</li>";

                }

                html = html +
                    "</ul>" +
                    "</div>" +
                    "</div>";
            }
            $("#StoryContent").prepend(html);
        }
    });
});
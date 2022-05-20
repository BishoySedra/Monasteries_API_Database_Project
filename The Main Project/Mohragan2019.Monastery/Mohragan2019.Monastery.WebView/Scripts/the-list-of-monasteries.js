$(document).ready(function () {
    $.ajax({
        url: "http://localhost:50961/api/Monastery/GetAll",
        type: "GET",
        cashe: false,
        contentType: "application/json",
        success: function(list) {
            for (var i = 0; i < list.length; i++) {
                $("#monasteryCards").append(
                    "<div class=\"col-sm-12 col-md-4 col-lg-4 col-xs-12\">" +
                    "<div class= \"thumbnail\">" +
                    "<a onclick = \"GetMonasteryId(" + list[i].ID + ")\">" +
                    "<img class = \"Image\" src=\"../Images/" + list[i].Image + "\">" +
                    "</a>" +
                    "<div class=\"caption\">" +
                    "<h4>" +
                    "<b>" + list[i].Name +
                    "</b>" +
                    "</h4>" +
                    "<h5><b>" + list[i].Description + "</b></h5>" +
                    "<button type=\"button\" class =\"btn btn-primary dropdown-toggle\" data-toggle=\"dropdown\" onclick = \"GetMonasteryId(" + list[i].ID + ")\">" +
                    "عرض المزيد" +
                    "</button>" +
                    "</div>" +
                    "</div>" +
                    "</div>");
            } // End For
        } //End Success
    }); //End Ajax For Showing The Cards


    $("#searchVal").keyup(function () { 
       var search = $("#searchVal").val();
        if (search === '') {
            $("#searchResult").hide('fade');
            $("#monasteryCards").show('fade');
        } else {
            $("#searchResult").show('fade');
            $("#monasteryCards").hide('fade');
        } //End Else


        $.ajax({
            url: "http://localhost:50961/api/Monastery/GetMonasteryBySearch",
            type: "GET",
            contentType: "application/json",
            data: { "search": search },
            success: function (list) {
                $("#searchResult").empty();
                if (list.length === 0) {
                    $("#searchResult").html(
                        "<div class=\"container\">" +
                        "<div class=\"jumbotron\">" +
                        "<p style=\"font-size:35px; text-align:center;\">" +  
                        "لا توجد نتائج !!!" +
                        "</p>" +
                        "</div>" +
                        "</div>" 
                    );
                }
                for (var x = 0; x < list.length; x++) {
                    $("#searchResult").append(
                       "<div class=\"col-sm-12 col-md-4 col-lg-4 col-xs-12\" style=\"float:right;\">" +
                       "<div class= \"thumbnail\">" +
                       "<a onclick = \"GetMonasteryId(" + list[x].ID + ")\">" +
                       "<img src=\"../Images/" + list[x].Image + "\">" +
                       "</a>" +
                       "<div class=\"caption\">" +
                       "<h4>" +
                       "<b>" + list[x].Name +
                       "</b>" +
                       "</h4>" +
                       "<h5><b>" + list[x].Description + "</b></h5>" +
                       "<button type=\"button\" class =\"btn btn-primary dropdown-toggle\" data-toggle=\"dropdown\" onclick = \"GetMonasteryId(" + list[x].ID + ")\">" +
                       "عرض المزيد" +
                       "</button>" +
                       "</div>" +
                       "</div>" +
                       "</div>"
                    );
                } //End For
            } // End Success
        }) // End Ajax For Search
    }); //End keyup
}); //End ready

function GetMonasteryId(id) {

    window.localStorage.setItem("MonansteryId", id);
    window.location.href = "History.html";

    if (id > 1) {
        window.location.href = "FailedToGetData.html";
    }
}





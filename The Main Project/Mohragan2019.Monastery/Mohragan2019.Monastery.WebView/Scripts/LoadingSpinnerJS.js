var myVar;
function myFunction() {
    myVar = setTimeout(showPage, 2000);
}

function showPage() {
    $("#loader").hide('fade');
    $("#myDiv").show('fade');
}
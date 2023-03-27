$(document).ready(function () {
    $("#menuContent").load("/Category/Index");
//    $.ajax({
//        type: "GET",
//        url: "/Category/Index",
//        /*data: { number1: val1, number2: val2 },*/
//        dataType: "text",
//        success: function (msg) {
//            //console.log(msg);
//            $("#menuContent").html(msg);
//        },
//        error: function (req, status, error) {
//            //console.log(req);
//            //console.log(status);
//            //console.log(error);
//        }
//    });

});

//setInterval(() => {

//})
//fetch("/Category/Index").then(response => {
//    console.log(response);
//    return response.text()
//}).then(data => {
//    console.table(data);
//    $('#menuContent').html(data);
//}).catch(error => {
//    console.error(error)
//})
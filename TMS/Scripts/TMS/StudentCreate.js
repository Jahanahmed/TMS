$(document).ready(function () {



});

var Student = [
    { Id: 1, Name: "Kamal" },
    { Id: 2, Name: "Jamal" }];

$(document.body).on("click", "#savebtn", function () {

    //$.ajax({

    //    //type
    //   // url
    //   // contentType
    //  //  data
    //  //  success

    //    type: "GET", 
    //    url: "/Students/Info",
    //    contentType: "application/json; charset=utf-8",
    //    data: JSON.stringify(),
    //    success: function (data) {
    //        alert(data.Name);
    //    }
    //});

    var url = "/Students/Info";
    $.get(url, function(responseData){
        alert(responseData);
    })

});
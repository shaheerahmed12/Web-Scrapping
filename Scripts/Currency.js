$(document).ready(function () {
    get();


});
function get() {

    var html = '';
    $.ajax({
        url: '/Home/Get',
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",

        success: function (result) {
            var data = result.Random;
            var html = "";
            for (var i = 1; i < data.length; i++) { // Loop through the data & construct the options
                html += '<tr><td >' + data[i].Currency + '</td><td>' + data[i].Symbol + '</td><td>' + data[i].Buying + '</td><td>' + data[i].Selling + '</td></tr>';

                 }
           
            $("#tbody").html(html);
        }
    }

    );
}
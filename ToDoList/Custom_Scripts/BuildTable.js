$(document).ready(fuction() {

    $.ajax({
        url: '/ToDo/BuildToDoTable',
        success: function (result) {
            $('#tableDiv').html.result;
        }
    });

});
$('#request').click(function () {


    $.ajax({
        type: "GET",
        dataType: "json",
        url: "/Creatures/spells",
        success: displaySpells,
        error: errorOnAjax
    });
})

function errorOnAjax() {
    console.log("ERROR on ajax request");
}



function displaySpells(data) {
    console.log(data);
    for (var i = 0; i < data.length; i++) {
        $('#spells').append($('<li>' + data[i] + '</li>'));
    }
}
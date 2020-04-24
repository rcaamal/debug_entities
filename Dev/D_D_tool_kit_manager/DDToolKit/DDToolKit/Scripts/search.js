$(document).ready(function () {

    $('#equipButton').hide();

    /*$('showEquip').onmouseover(function () {
        alert("Single click to show the search. double click to hide it");
    });*/

    $('#showEquip').click(function () {
        $('#equipButton').show();
    })

    $('#showEquip').dblclick(function () {
        $('#equipButton').hide();
    })



});
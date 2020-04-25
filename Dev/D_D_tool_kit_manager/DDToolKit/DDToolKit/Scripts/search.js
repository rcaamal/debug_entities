$(document).ready(function () {

    $('#smallFrame').hide();
    $('#midFrame').hide();
    $('#LargeFrame').hide();

    /*$('showEquip').mouseover(function () {
        alert("Single click to show the search. double click to hide it");
    })*/
   
    $('#smallScreen').click(function () {

        $('#smallFrame').show();

    });

    $('#midScreen').click(function () {
        $('#midFrame').show();

    });

    $('#LargeScreen').click(function () {
        $('#LargeFrame').show();

    });

    $('#smallScreen').dblclick(function () {
        $('#smallFrame').hide();
    });

    $('#midScreen').dblclick(function () {
        $('#midFrame').hide();
    });

    $('#LargeScreen').dblclick(function () {
        $('#LargeFrame').hide();
    });



});
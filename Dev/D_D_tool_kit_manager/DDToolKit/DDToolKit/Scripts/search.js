$(document).ready(function () {

    $('#smallFrame').hide();
    $('#midFrame').hide();
    $('#LargeFrame').hide();

    $('#MonstersmallFrame').hide();
    $('#MonstermidFrame').hide();
    $('#MonsterLargeFrame').hide();



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


    // Monsters code below :

    $('#MonstersmallScreen').click(function () {

        $('#MonstersmallFrame').show();

    });

    $('#MonstermidScreen').click(function () {
        $('#MonstermidFrame').show();

    });

    $('#MonsterLargeScreen').click(function () {
        $('#MonsterLargeFrame').show();

    });

    $('#MonstersmallScreen').dblclick(function () {
        $('#MonstersmallFrame').hide();
    });

    $('#MonstermidScreen').dblclick(function () {
        $('#MonstermidFrame').hide();
    });

    $('#MonsterLargeScreen').dblclick(function () {
        $('#MonsterLargeFrame').hide();
    });



});



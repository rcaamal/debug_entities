$(document).ready(function () {

    /* $('#SmartSpell').change(function () {
         var temp = $("#SmartSpell").val();
         //console.log(temp);
         $.ajax({
             url: "/Spell/smartSearch",
             dataType: "json",
             data: { search: temp },
             success: ShowList,
             error: function (xhr, status, error) {
                 alert("error");
             }
         });
     });*/


    $("#smartEquip").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Equipment/smartSearch",
                dataType: "json",
                data: { search: $("#smartEquip").val() },
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.Name/*, value: item.Name*/ };

                    }));
                },
                error: function (xhr, status, error) {
                    alert("error");
                }
            });
        }
    });
});
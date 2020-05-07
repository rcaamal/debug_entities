$(document).ready(function () {

    $("#SmartSpell").on("change"
         function (request, response) {
            $.ajax({
                url: "/Spell/smartSearch",
                dataType: "json",
                data: { search: $("#SmartSpell").val() },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {label: item.Name, value: item.Name};
                    }));
                },
                error: function (xhr, status, error) {
                    alert("error");
                }
            });
         }
    );

});
$(document).ready(function () {
    $("#Name").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Spell/Index",
                type: "POST",
                datatype: "json",
                data: { Prefix: request.term },
                success: function (data) {
                    response($.map(data, function (data) {
                        return { label: item.Name, value: item.Name };
                    }))
                }
            })
        },
        messages: {
            noResults: "", results: ""
        }
    });
})
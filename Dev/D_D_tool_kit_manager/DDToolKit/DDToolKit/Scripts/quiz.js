$(document).ready(function () {
    $('#quizSubmit').on("click", function () {
        var input1 = document.querySelector('input[name="q1"]:checked').value;
        var input2 = document.querySelector('input[name="q2"]:checked').value;
        var input3 = document.querySelector('input[name="q3"]:checked').value;
        var input4 = document.querySelector('input[name="q4"]:checked').value;
        var input5 = document.querySelector('input[name="q5"]:checked').value;
        var input6 = document.querySelector('input[name="q6"]:checked').value;
        var input7 = document.querySelector('input[name="q7"]:checked').value;
        var input8 = document.querySelector('input[name="q8"]:checked').value;
        var input9 = document.querySelector('input[name="q9"]:checked').value;
        var input10 = document.querySelector('input[name="q10"]:checked').value;

        $.ajax({
            type: "GET",
            dataType: "json",
            url: "/Quiz/Questions",
            data: {
                Ans1: input1,
                Ans2: input2,
                Ans3: input3,
                Ans4: input4,
                Ans5: input5,
                Ans6: input6,
                Ans7: input7,
                Ans8: input8,
                Ans9: input9,
                Ans10: input10
            },
            error: errorOnAjax
        });
    });



    $('#showAnswers').hide();
    $('#viewAnswers').click(function () {

        $('#showAnswers').show();

    });
});

function errorOnAjax(data) {
    console.log(data.responseText);
}



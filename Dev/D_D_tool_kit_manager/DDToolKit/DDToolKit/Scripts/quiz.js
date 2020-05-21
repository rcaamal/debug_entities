function quizCalculator() {
   
    var result = 0;

    if (document.querySelector('input[name="q1"]:checked').value == 1) {
        result = result + 1;
        document.getElementById("Ans1").innerHTML = "Correct";
    }
    else {
        document.getElementById("Ans1").innerHTML = "Incorrect";
    }
    if (document.querySelector('input[name="q2"]:checked').value == 3) {
        result = result + 1;
        document.getElementById("Ans2").innerHTML = "Correct";
    }
    else {
        document.getElementById("Ans2").innerHTML = "Incorrect";
    }

    $('#answersubmit').click(function () {

       document.getElementById("showAnswers").innerHTML = totalScore + "/2";

    });

    //document.getElementById("total").innerHTML = totalScore + "/2";
};
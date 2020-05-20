function quizCalculator() {
    var results = 0;
    if (document.querySelector('input[name="q1"]:checked').value == 2) {
        totalScore = totalScore + 1;
        document.getElementById("a1").innerHTML = "Correct";
    }
    else {
        document.getElementById("a1").innerHTML = "Incorrect";
    }
}
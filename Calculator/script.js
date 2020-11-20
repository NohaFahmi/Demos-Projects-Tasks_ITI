var equation = 0;
var screen = document.getElementById('Answer');

function EnterEqual() {
                
    var result = eval(equation);
    screen.value = result;

    return result;

}

function EnterNumber(x) {
    equation += parseInt(x);
    screen.value = equation;
    return equation;
}

function EnterOperator(s) {
    equation += s;
    screen.value = equation;
    return equation;
}

function EnterClear() {
    screen.value = '';
    equation = 0;
}

//todo: scientific Calculator

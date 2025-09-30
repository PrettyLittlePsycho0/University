const input = document.getElementById("input");
const output = document.getElementById("output");

function buttonpress(element) {
    if (element.innerText === "AC") {
        input.innerText = "";
        output.innerText = "";
    }
    else if (element.innerText === "<") {
        input.innerText = input.innerText.slice(0, -1);
    }
    else if (element.innerText === "=") {
        calculate();
    }
    else {
        input.innerText += element.innerText;
    }
}

const operators = ['+', '-', '×', '÷'];

function calculate() {
    let expression = input.innerText
        .replace(/×/g, "*")
        .replace(/÷/g, "/")
        .replace(/\s+/g, ""); 
    if (expression === "") {
        output.innerText = "Input is empty!";
        return;
    }
    
    try {
        const result = eval(expression);
        if (typeof result === "number" && isFinite(result)) {
            output.innerText = result;
        } else {
            output.innerText = "Math Error!";
        }
    } catch (e) {
        output.innerText = "Invalid Expression!";
    }
}

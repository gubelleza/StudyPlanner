// Function definitions
// range input functions

class RangeOutput {
    
    textStyle;
    element;
    
    constructor(textStyle) {
        this.textStyle = textStyle;
        this.element = document.getElementById("outPrioridade")
    }
    
    setText(text) {
        this.element.innerHTML = text;
    }
    
    setStyle(newStyle) {
        this.element.classList.replace(this.textStyle, newStyle);
        this.textStyle = newStyle;
    }
    
    applyPriorityStyle = (input) => {
        switch (input.value) {
            case "1":
                this.setStyle("text-success")
                this.setText("Minima")
                break;
            case "1.5":
                this.setStyle("text-info");
                this.setText("Baixa")

                break;
            case "2":
                this.setStyle("text-dark");
                this.setText("Normal")

                break;
            case "2.5":
                this.setStyle("text-warning");
                this.setText("Alta")
                break;
            case "3":
                this.setStyle("text-danger");
                this.setText("Maxima")
                break;
            default:
                this.setStyle("text-dark");
                console.log("default")
                this.setText("Normal")

                break;
        }
    }
}

// Function calls
// Range input function calls
let input = document.getElementById("inputPrioridade");
let output = new RangeOutput("text-dark")

output.setText(input.value);

input.oninput = function (){    
    output.applyPriorityStyle(this)
}


function outputPrioridade() {
    document.getElementById("#out-prioridade").innerText =
        document.getElementById("#prioridade").getAttribute("value");
}

document.getElementById("#prioridade")
    .addEventListener("mouseup", outputPrioridade);

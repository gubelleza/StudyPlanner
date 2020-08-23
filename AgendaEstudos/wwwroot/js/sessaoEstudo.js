function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms))
}

const secToTime = (sec) => {
    let time = new Date(
        0, 0, 0, 0, 0, 0);
    time.setSeconds(sec);
    return time.toTimeString().split(" ")[0];
}

const counter = async () => {
    let value = 1;
    const displayElement = document.getElementById("contador");
    
    while (true) {
        displayElement.innerText = secToTime(value);
        await sleep(1000);
        console.log(value);
        value++;

    }
}

counter();
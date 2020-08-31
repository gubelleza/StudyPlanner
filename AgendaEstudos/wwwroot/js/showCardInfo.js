
class Button {
    
    btnElement;
    iconElement;
    showMoreIcon = "text-success fas fa-plus-circle".split(" ");
    hideContentIcon = "text-danger fas fa-minus-circle".split(" ");
    clicked = false;
    
    constructor(buttonId, iconId) {
        this.btnElement = document.getElementById(buttonId);
        this.iconElement = document.getElementById(iconId);
    }
    
    wasClicked() {
        return this.clicked;
    }
    
    act() {
        return this.btnElement;
    }
    
    showMore() {
        this.iconElement.classList.replace(
            this.showMoreIcon[0], this.hideContentIcon[0]);
        this.iconElement.classList.replace(
            this.showMoreIcon[2], this.hideContentIcon[2]);
        this.clicked = true;
    }
    
    hideContent() {
        this.iconElement.classList.replace(
            this.hideContentIcon[0], this.showMoreIcon[0]);
        this.iconElement.classList.replace(
            this.hideContentIcon[2], this.showMoreIcon[2]);
        this.clicked = false;
    }
}

class CardInfo {
    
    infoElement;
    hidden = true;
    
    constructor(infoElementId) {
        this.infoElement = document.getElementById(infoElementId);
    }
    
    showInfos() {
        this.infoElement.removeAttribute("hidden");
        this.hidden = false;
    }
    
   hideInfos() {
        this.infoElement.setAttribute("hidden", "true");
        this.hidden = true;
    }
}

class CardsEventHandler {
    
    button;
    cardInfo;
    
    constructor(buttonObj, cardInfoObj) {
        this.button = buttonObj;
        this.cardInfo = cardInfoObj;
    }
    
    listenEvents() {
        this.button.act().addEventListener(
            "click", () => {this.toggleCardInfoEvent(this)})
    }
    
    toggleCardInfoEvent(handler) {
        if (handler.button.wasClicked()) {
            handler.button.hideContent();
            handler.cardInfo.hideInfos();
        } else {
            handler.button.showMore();
            handler.cardInfo.showInfos();
        }
    }
    
}

let countCards = () => {
    return document.getElementsByClassName("card-body");
}

for (let i=1; i <= countCards().length; i++){
    let btn = new Button(
        `display-infos-btn-${i}`, `display-control-${i}`);
    let cardInfo = new CardInfo(`infos-tarefa-${i}`);
    let handler = new CardsEventHandler(btn, cardInfo);

    handler.listenEvents();
}


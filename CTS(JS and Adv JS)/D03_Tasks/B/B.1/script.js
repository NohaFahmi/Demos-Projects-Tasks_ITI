// document.getElementById('n').onclick =  function () {
    
//     alert('Your info will be sent to the server!');
//     console.log(this.value);

// }

var heading = document.getElementById('h');
window.onkeydown = function(e) {

    //validation are working in order!!!!
    if(e.shiftKey) {
        heading.innerHTML = "Shift key has been presses!!";
        // console.log("Shift key has been presses!!");f
    }
    else if(e.ctrlKey) {
        heading.innerHTML = "Ctrl key has been presses!!";

        // console.log("Ctrl key has been presses!!");
    }
    else if(e.altKey) {
        heading.innerHTML = "Alt key has been presses!!";

        // console.log("Alt key has been presses!!");
    }
        
    else {
        heading.innerHTML = "Key with a code of " + e.keyCode + " has been presses!!"
        // console.log("Key with a code of " + e.keyCode + " has been presses!!");
    } 

}


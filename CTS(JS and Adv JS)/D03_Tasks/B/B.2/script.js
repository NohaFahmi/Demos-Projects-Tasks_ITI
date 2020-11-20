// window.oncontextmenu = function() {
//     alert("Context Menu is Prevented!!");
//     return false;
// }

window.onmousedown = function(e) {
    if(e.button == 2) {
        alert("Context Menu is Prevented!!");
        console.log(e);
        console.log(e.button);
        e.preventDefault();
    }
}


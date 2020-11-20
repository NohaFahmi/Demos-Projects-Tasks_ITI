document.forms[0].onsubmit = function() {
    
    var confirmSubmission = confirm("Are you sure that you want to submit these Info?");

    if(confirmSubmission) {
        return true;
    }else {
        return false;
    }
    // e.preventDefault();
}
var newEvt = new Event('timeout');
// var input = //


document.getElementById('name').addEventListener('timeout', function() {

    clearTimeout(timer);
}); 

var timer = setTimeout(function() {
    
    alert('You have not filled the form yet!!');
    document.getElementById('name').dispatchEvent(newEvt);
    
}, 3500);







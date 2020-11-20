function addition() {
    var sum = 0;
    try {

        if(arguments.length === 0)  {
            throw "Invalid function usage!!";
        }
        
        for(var i=0; i< arguments.length; i++) {

            if(isNaN(arguments[i])) {
                throw new TypeError("Invalid Data Type!");
                sum = 0;
            }
            
            sum += arguments[i];  

        }
    }
    catch(e) {

        if(e instanceof TypeError) {
            console.log(e.name);
            console.log(e.message);
        }
        if(e === "Invalid function usage!!"){
            console.log("Missing Parameters");
        }
    }
    
    return sum;
}
document.getElementById('btn').onclick = function() {
    console.log(addition(1,2,3,5,6,6,10,101));
    console.log("--------------");
    console.log(addition("abc", 1, 4));
    console.log("--------------");
    console.log(addition());
}



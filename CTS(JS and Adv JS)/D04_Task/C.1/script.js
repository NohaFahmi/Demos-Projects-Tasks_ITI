document.getElementById('btn').onclick = function () {
    console.log(notExceed(1, 2, 4, 5, 6));
    console.log("--------------");
    console.log(notExceed(1));
    console.log("--------------");
    console.log(notExceed(1,2));

} 

function notExceed() {

    try{
        var sum = 0;
        if(arguments.length > 2) {
            throw new RangeError("Parameters Numbers out of Range!!");
        }
        if(arguments.length < 2) {
            throw new RangeError("Parameters Numbers are less than expected!"); 
        } 

        sum = arguments[0] + arguments [1];
    }
    catch(e) {

        if(e instanceof RangeError) {   
            console.log(e.name);
            console.log(e.message);
        }
    }

    return "the numbers are: [" + arguments[0] + ", " + arguments[1] + "]\n the result is : " + sum;
}
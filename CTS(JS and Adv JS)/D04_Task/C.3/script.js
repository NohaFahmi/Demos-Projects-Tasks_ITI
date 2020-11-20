//method 1
function reverseArr() {
    var arr = [];
    if(arguments.length > 0) {
        for(var i=0; i < arguments.length; i++) {

            arr.push(arguments[i]);
        }
        
      
    }

    return arr.reverse();
}

console.log(reverseArr(0, 4, 5, 6, 2, 1,4));

//Method2
function reversed(arr) {

    return [].reverse.call(arr);
}

console.log(reversed([2, 5, 7, 6, 8, 10]));

//Method 2
// var reversed = function() {

//     var arr = [];
//     for(var i=arguments.length-1; i > 0; i--) {
//         arr.push(arguments[i]);
//     }

//     return arr;
// }

// console.log(reversed(2, 5, 7, 6, 8, 10));


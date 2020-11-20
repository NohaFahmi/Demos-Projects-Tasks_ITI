//custom object that has getSetGen as function value
var generated = {
    getSetGen: function(obj) {
        // var getSetArr = [];
        // var get;
        // var set;

        for(var prop in obj) {
            //to capitalize the first letter in second word
            var propName = prop.charAt(0).toUpperCase() + prop.slice(1);
            //getter
            obj['get' + propName] = (function(i) {
                
                return function() {

                    return obj[i];
                }
            })(prop);
            //setter
            obj['set' + propName] = (function(i) {
               return function(val) {
                   obj[i] = val;
               }
                
            })(prop);

            // getSetArr.push(get);
            // getSetArr.push(set);
        }

    }

}

//
var user = { name:'Ali' ,age:10};
var newObj = {id:'SD-10',location:'SV', addr: '123 st.'};
// generated.getSetGen(user)[1](16);
// console.log(generated);
generated.getSetGen(user);
console.log(user);
console.log(user.getName());//10 // ali
console.log('-----------------');
user.setName('Noha');
console.log(user);
console.log(user.getName());//10 // ali //Noha
var res = generated.getSetGen.bind(newObj);
console.log('-----------------');
res(newObj);
console.log(newObj);
console.log(newObj.getId());
console.log(newObj.getAddr());
console.log(newObj.getLocation());
newObj.setAddr('Cairo');
console.log(newObj);
console.log(newObj.getAddr());






// console.log(generated.getSetGen(user)[0]());


// var generated = {
//     getSetGen: function(obj) {
//         // var getSetArr = [];
//         // var get;
//         // var set;
//         for(var prop in obj) {
//             var propName = prop.charAt(0).toUpperCase() + prop.slice(1);
//             obj['get' + propName] = (function(i) {
                
//                 return function() {
//                     return obj[i];
//                 }
//             })(prop)

//             obj['set' + propName] = (function(val, i) {
               
//                return function() {
//                    this.i = val;
//                }
//             })(prop)

//             // getSetArr.push(get);
//             // getSetArr.push(set);
//         }

//     }

// }
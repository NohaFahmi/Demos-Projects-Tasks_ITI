//properties should be defined using accessor descriptor,prevent them from being deleted, iterated or being modified


Object.defineProperties(Numerical, {
    start: {
        set: function(s){start = s},
        get: function(){return this.start},
        
    },
    end: {
        set: function(e){end = e},
        get: function(){return this.end},

    },
    step: {
        set: function(stp){step = stp},
        get: function(){return this.step},

    }
});
//Creating the constructor
function Numerical(s, e, stp) {

    var start = s;
    var end = e;
    var step = stp;
    var numericalList = [];

    //private method to fill the list
    function fillingList() {
        // numericalList.push(that.start);
        //1 , +2 //20
        //1,3,5,7,9,11,13,15,17,19
        for(var i = start; i < end; i=i+step) {
            numericalList.push(i);
        }

        return numericalList;
    }
    //force the private method to use the caller object!
    var fillList = fillingList.bind(this);
    fillList();
    //list getter method
    this.getNumericalList = function() {
        
        return numericalList;
    }
    //list setter method
    this.setIntoList = function(i, n, val) {
        if(val !== undefined) {
            numericalList.splice(i, n, val);

        }
        numericalList.splice(i, n);
    }
    
}
//Dequeue or pop a value
Numerical.prototype.removeValue = function(val) {
    var list = this.getNumericalList();
    for(var i=0; i<list.length; i++) {
        if(list[i] === val) {
            var that = this;
            var res = (function(j) {
                return that.setIntoList(j, 1);
            })(i);
        }
    }
}

// Append pr Prepend a new value
Numerical.prototype.appendValue = function(val) {
    var list = this.getNumericalList();
    
    try {

        if((val > Math.max(...list)) || (val < Math.min(...list))) {

            throw new RangeError('This Value exceeds the range of the list!');
        }

        this.setIntoList(0, 0 , val);
        console.log("Value is added!");
    }
        
    catch(e) {
        if(e instanceof RangeError) {
            console.log(e.message);
        }
        
    }
    return "The list now is: [" + list + "]";
}

//Display its content
Numerical.prototype.display = function() {
    console.log(this.getNumericalList());
}
var sqList1 = new Numerical(1, 20, 3);
Object.seal(sqList1);

console.log(sqList1.getNumericalList());
console.log(sqList1.getNumericalList());
sqList1.removeValue(17);
// sqList1.setIntoList(3, 1);
console.log(sqList1.getNumericalList());
console.log(sqList1.appendValue(10));
console.log(sqList1.appendValue(4));
console.log(sqList1.appendValue(24));
sqList1.display();

// var sqList2 = new Numerical(4, 100, 5);
// console.log(sqList2);
// console.log(sqList2.getNumericalList());
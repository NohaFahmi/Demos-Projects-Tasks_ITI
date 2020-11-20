function Rectangle(w, h) {
   
    this.width= w;

    this.height = h;

    this.getArea= function() {

        return w * h;
    };
    this.getPerimeter= function() {

        return 2 * (w + h);
    };

    
}

var rect1 = new Rectangle(12, 10);
var rect2 = new Rectangle(2, 3);
var rect3 = new Rectangle(100, 50);

function displayInfo(obj) {

    var msg = "The width = " + obj.width +" and Height = " + obj.height + "\nArea is: " + obj.getArea() + "\nPerimeter is: " + obj.getPerimeter();

    return msg;
}
// console.log(rect1);

console.log(displayInfo(rect1));
console.log(displayInfo(rect2));
console.log(displayInfo(rect3));

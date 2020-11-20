var Shape = function(w, h) {

    if(this.constructor === Shape) {
        throw "Creating instances from Shape isn't allowed!!";
    }

    if(this.constructor === Rectangle && Shape.instances > 1) {
        throw "Creating more than one Rectangle is not allowed!!";
    }

    if(this.constructor === Square && Shape.instances > 1) {
        throw "Creating more than one Square is not allowed!!";
    }

    Shape.instances++;

    this.width = w;
    this.height = h;
}

var Rectangle = function(w, h) {
    Shape.call(this,w, h);

}

var Square = function(w) {
    
    Rectangle.call(this,w);
    

};

Rectangle.prototype = Object.create(Shape.prototype);
Rectangle.prototype.constructor = Rectangle;
Square.prototype = Object.create(Rectangle.prototype);
Square.prototype.constructor = Square;

Rectangle.prototype.calcArea = function() {
    
    return (this.height === undefined) ? this.width * this.width : this.width * this.height;
}

Rectangle.prototype.calcPerimeter = function() {

    return (this.height === undefined) ? (4 * this.width) : (2 * (this.width + this.height));
}

//override toString() method
Rectangle.prototype.toString = function() {
    return `This Shape has a width = ${this.width}, and a height = ${this.height}\nThe area is = ${this.calcArea()}\nThe Perimeter is = ${this.calcPerimeter()}`;
}

//Create Class Property that counts numbers of created objects and Class method to retrieve it.

Shape.instances = 0;
Shape.countInstances = function() {
    return Shape.instances;
}



var rect1 = new Rectangle(3, 5);


var sqr1 = new Square(2);

console.log('--------------Square---------------');

console.log(sqr1);
console.log(sqr1.calcArea());
console.log(sqr1.calcPerimeter());
console.log(sqr1.toString());

console.log('---------------Rectangle--------------');
console.log(rect1.calcArea());
console.log(rect1.calcPerimeter());
console.log(rect1.toString());

console.log('-----------------------------');

console.log(Shape.countInstances());

// console.log(Rectangle.prototype);
console.log('---------------Shape--------------');
//allow creation of only one square and one rectangle
try {
    var shape1 = new Shape(3, 4);
}
catch (e) {

    var rect2 = new Rectangle(32, 15);
}
finally {
    var sqr2 = new Square(5);

}
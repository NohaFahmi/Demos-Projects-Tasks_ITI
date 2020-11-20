var Rectangle = function(w, h) {
    this.width = w;
    this.height = h;
    Rectangle.instances++;
}

//2 extended methods (using prototype property) for calculating area, perimeter.

Rectangle.prototype.calcArea = function() {
    return this.width * this.height;
}

Rectangle.prototype.calcPerimeter = function() {
    return (2 * (this.width + this.height));
}

//override toString() method
Rectangle.prototype.toString = function() {
    return `This Rectangle has a width = ${this.width}, and a height = ${this.height}\nThe area is = ${this.calcArea()}\nThe Perimeter is = ${this.calcPerimeter()}`;
}

//Create Class Property that counts numbers of created objects and Class method to retrieve it.

Rectangle.instances = 0;
Rectangle.countInstances = function() {
    return Rectangle.instances;
}

var rect1 = new Rectangle(3, 5);
var rect2 = new Rectangle(32, 15);
var rect3 = new Rectangle(3.5, 5);
// var rect4 = new Rectangle(3.6, 5.7);

console.log(rect1.calcArea());
console.log(rect1.calcPerimeter());
console.log(rect1.toString());
console.log('-----------------------------');

console.log(rect1);
console.log(rect2);
console.log(rect3);
// console.log(rect4);
console.log('-----------------------------');
console.log(Rectangle.countInstances());

// console.log(Rectangle.prototype);
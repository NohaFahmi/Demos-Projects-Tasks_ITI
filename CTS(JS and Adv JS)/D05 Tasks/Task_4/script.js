var Book = function(t, ch, auth, pg, pub, cp, bkType) {
    
    this.title=t;
    this.numOfChapters=ch;  
    this.author=auth;
    this.numOfPages=pg;
    this.publisher=pub;
    this.numOfCopies=cp;
    this.bookType = bkType;

}

var Box = function(h, w, l, v, mtr) {
    this.height = h;
    this.width = w;
    this.length = l;
    this.content = [];    
    this.numOfBooks = this.content.length;
    this.volume = (v === undefined) ? 10 : v;
    this.material = mtr;

    //add Books to Box
    this.addToBox = function(obj) {
        
        for(var i=0; i<obj.length; i++) {
            var that = this;
            var res = (function (j) {
                that.content.push(obj[j]);
                that.numOfBooks ++;
            })(i);
        }
        
        
    }
    //count # of books inside box
    this.countBooks = function() {

        return this.content.length;
    }

    //delete any of these books in box according to book name or type
    this.deleteABookByName = function(nm) {
        for(var i=0; i < this.content.length; i++) {
            var that = this;
            var res = (function(j) {
                if(that.content[j].title === nm) {
                    that.content.splice(j, 1);
                }
            })(i);
        }
        return this.content;
    }

    this.deleteABookByType = function(t) {
        for(var i=0; i < this.content.length; i++) {
            var that = this;
            var res = (function(j) {
                if(that.content[j].bookType === t) {
                    that.content.splice(j, 1);
                }
            })(i);
        }
        return this.content;
    }

    

}


var book1 =  new Book('Harry Potter and the Philosopher\'s Stone', 17, 'J. K. Rowling', 223, 'UK', 3, 'ScF');

var book2 = new Book('Harry Potter and the Chamber of Secrets', 18, 'J. K. Rowling', 223, 'UK', 3, 'ScF');

var book3 = new Book("utopia", 5, "A.K.T", 200, "EG", 2, 'Drama');

var book4 = new Book("The legend of Legends", 9, "A.K.T", 220, "EG", 6, 'Thriller');

var book5 = new Book("A Boring Legend", 5, "A.K.T", 100, "EG", 12, 'Thriller');

var book6 = new Book('Harry Potter and the Half-Blood Prince', 30, 'J. K. Rowling', 223, 'UK', 6, 'ScF');

var book7 = new Book('Harry Potter and the Deathly Hallows', 37, 'J. K. Rowling', 223, 'UK', 5, 'ScF');

var box1 = new Box(40, 100, 50, 20, 'wood');
var box2 = new Box(50, 50, 30, 10, 'Plastic')
//use .toString() to tell its dimensions and how books are stored in it
Box.prototype.toString = function() {
    return `This box's dimensions are: width: ${this.width}, height: ${this.height}, length: ${this.length},\nIt contains ${this.numOfBooks} books`;
}

//implement .valueof() so that if there is more than one box object we can get total books in these boxes
Box.prototype.valueOf = function() {
    return this.numOfBooks;
}

box1.addToBox([book2, book6, book3]);

box2.addToBox([book1, book7, book4, book5]);

console.log(box1.content);//3
console.log(box2.content);//4

console.log(box1.toString());
console.log(box2.toString());

console.log(box1.valueOf() + box2.valueOf());//7

// console.log(book1);

// console.log(box1.content);
// console.log(box1.countBooks());
console.log(box1);
console.log(box2);



// box1.deleteABookByName('Harry Potter and the Deathly Hallows');
// box1.deleteABookByType('ScF');
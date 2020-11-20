var linkedList = {};

var arr = [3, 5, 6,7,"abc", "k"];

Object.defineProperties(linkedList, {
    content: {
        value: arr,
        // configurable: true,
    },
    push: {
        value: function(val) {
             
            this.content.push(val);
            return this.content;
        }
    },
    pop: {
        value: function() {
            
            this.content.pop();
            return this.content;

        }
    },
    display: {
        value: function() {
            for(var i=0; i<this.content.length; i++) {
                console.log(this.content[i]);
            }
        }
    },

    insert: {
        value: function(i, val) {

            this.content.splice(i, 0, val);

            return this.content;
        }
    }

});


console.log(linkedList.content);
console.log(linkedList.push(3));
console.log(linkedList.pop());
console.log(linkedList.display());
console.log(linkedList.insert(3, "Noha"));

linkedList.content = ["noha", "noway", "hi"];
delete linkedList.content;
console.log(linkedList.content);









wait5sec();

console.log("start");

setTimeout(function(){console.log("setTimeout");},0);

for(var i=0;i<3;i++){
    console.log(i);
    
    setTimeout(function(){
        console.log("for loop"+i);
    },0)
    
}
console.log(i);//
fun();

console.log("end");

function fun(){
    
    
    console.log("function");
    
}


function wait5sec() {
	//console.log("start of fun exec " + new Date().getSeconds() + ":" + new Date().getMilliseconds());
	
	var ms = (new Date()).getTime() + 5000;
	
	while (ms > (new Date().getTime())) {
        //console.log(ms);
        
    }
	
	//console.log("end of function exec " + new Date().getSeconds() + ":" + new Date().getMilliseconds());

	}
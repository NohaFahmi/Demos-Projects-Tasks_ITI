var container = document.getElementById('container');
var images = document.getElementsByTagName('img');
var slideShow;
var currentIndex = 0;//0:5
images[currentIndex].style.display = 'block';

function next() {
    currentIndex++;
    if(currentIndex > images.length-1) {

        currentIndex = images.length-1;
    }
    images[currentIndex].style.display = 'block';
    
    for(var i=currentIndex; i<images.length-1; i++) {
        images[i+1].style.display = 'none';
    }
    for(var i=currentIndex; i>0; i--) {
        images[i-1].style.display = 'none';
    }
} 

function previous() {
    if(currentIndex > 0) {
        currentIndex--;
    } else {
        currentIndex=0;
    }
    images[currentIndex].style.display = 'block';
    
    for(var i=currentIndex; i<images.length-1; i++) {
        images[i+1].style.display = 'none';
    }
    for(var i=currentIndex; i>0; i--) {
        images[i-1].style.display = 'none';
    }

}

function displayAll() {
    currentIndex++;
    if(currentIndex > images.length-1) {

        currentIndex = 0;
    }
    images[currentIndex].style.display = 'block';
    
    for(var i=currentIndex; i<images.length-1; i++) {
        images[i+1].style.display = 'none';
    }
    for(var i=currentIndex; i>0; i--) {
        images[i-1].style.display = 'none';
    }

    slideShow = setTimeout(displayAll, 2000);
}



function stop() {

    clearTimeout(slideShow);
    currentIndex = images.length-1;
}


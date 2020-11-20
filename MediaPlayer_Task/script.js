var playBtn = document.querySelector('.play-btn');
var stopBtn = document.querySelector('.stop-btn');
var pauseBtn = document.querySelector('.pause-btn');
var song = document.getElementById('song');
var source =document.getElementById('song_src');
var img = document.querySelector('.arts-img');
var muteBtn = document.getElementById('mute');
var progress = document.querySelector('#audio-progress');
var volumeUpdate = document.querySelector('#volume');

//a value to represent the current song playing
var n =1;
function changeSource(elem) {
    // console.log(elem.id)
    n = parseInt(elem.id);

    //change the src of image
    img.src = './images/' + elem.id + '.jpg';

    //change the src of audio
    song.src = './audios/' + elem.id + '.mp3';
    song.play();

    //set duration to be max value of progress bar
    song.onloadedmetadata = function() {
        
        progress.max = song.duration;
        progress.step = song.currentTime;
        progress.min = 0;

    }
    
}

document.getElementById('1').addEventListener('click', function() {
    
    changeSource(this);
    console.log(n);
    //toggle the class playing that changes the style of song name
    this.classList.add('playing');
    document.getElementById('2').classList.remove('playing');
    document.getElementById('3').classList.remove('playing');
    document.getElementById('4').classList.remove('playing');
});

document.getElementById('2').addEventListener('click', function() {
    changeSource(this);

    //toggle the class playing that changes the style of song name
    this.classList.add('playing');
    document.getElementById('1').classList.remove('playing');
    document.getElementById('3').classList.remove('playing');
    document.getElementById('4').classList.remove('playing');
})

document.getElementById('3').addEventListener('click', function() {
    changeSource(this);
    
    //toggle the class playing that changes the style of song name
    this.classList.add('playing');
    document.getElementById('1').classList.remove('playing');
    document.getElementById('2').classList.remove('playing');
    document.getElementById('4').classList.remove('playing');
})

document.getElementById('4').addEventListener('click', function() {
    changeSource(this);

    //toggle the class playing that changes the style of song name
    this.classList.add('playing');
    document.getElementById('2').classList.remove('playing');
    document.getElementById('3').classList.remove('playing');
    document.getElementById('1').classList.remove('playing');
})

//set the play button 
playBtn.onclick = function() {

    song.play();

}

//set the pause button 
pauseBtn.onclick = function() {
    
    song.pause();
}

//set the stop button
stopBtn.onclick = function() {
    
    song.load();
}

//set the mute button
muteBtn.onclick = function() {
    // console.log(song.muted);
    if(!song.muted) {

        song.muted = true;
        muteBtn.innerHTML = 'unmute';

    } else {

        song.muted = false;
        muteBtn.innerHTML = 'mute';
    }
 
}

//set progress bar changes with audio time changing
song.ontimeupdate = function() {

    progress.value = this.currentTime;
}

//set audio time changes with progress bar changing
progress.oninput = function() {
    
    song.currentTime = progress.value;

}
//auto playing next song after current one ended
song.onended = function () {
    
    n =(n >= 4) ? 1 : n +1 ;
    if(n === 1) {
        document.getElementById('4').classList.remove('playing');
    } else {
        
        document.getElementById('' + (n-1)).classList.remove('playing');

    }
    document.getElementById('' + n).classList.add('playing');
    song.src = `./audios/${n}.mp3`;
    img.src = `./images/${n}.jpg`;
    song.play();

}

//set audio volume changes with volume bar
volumeUpdate.oninput = function() {
    
    song.volume = volumeUpdate.value;
}

//set volume bar changes with audio volume 
song.onvolumechange = function() {
    volumeUpdate.value = this.volume;
}

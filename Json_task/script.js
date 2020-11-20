var bands = document.getElementById('bands');
var artistOptions = document.getElementById('artists');
var chosenBand;
var res;


//using Promise and XHR
bands.addEventListener('change', 
    function() {
        chosenBand = bands.value;
        let p = new Promise((resolve, reject) => {
            console.log('Promise has started!!');
        
            var xhr = new XMLHttpRequest();
            xhr.open('GET', 'rockbands.json');
            xhr.send('');

            xhr.onreadystatechange = function() {
                if(xhr.readyState == 4) {
                    if(xhr.status == 200) {
                        res = JSON.parse(xhr.responseText);
                        resolve(res);
                        
                    }
                    reject('Data is not found!!');
                }
                p.then((data) => {
                    console.log(data);
    
                    resetOptions();
                    createDisableOpt();
                    for(var i=0; i < data[chosenBand].length; i++) {
                        // console.log(res[chosenBand][i]);
                        fillArtistOpt(data[chosenBand][i].name);
                    }
                })
    
                .catch((err) => {
                    console.log(err);
                })
            }
            
           

            console.log('working');
        })
        
    

    // console.log(chosenBand);
});
artistOptions.onchange = function() {
    
    for(var i=0; i < res[chosenBand].length; i++) {
        for(var a in res[chosenBand][i]) {
            if(res[chosenBand][i][a] === artistOptions.value) {
                // console.log(res[chosenBand][i]);
                open(res[chosenBand][i].value, "_blank")
            }
        }
    }

}

/* ---------------------------------------------------- */
//using fetch
/* bands.addEventListener('change', 
    function() {
        chosenBand = bands.value;
        fetch('rockbands.json', {method: 'GET'})
        //resolving
        .then((response) => {
            return response.json();
        })
        .then((res) => {
            console.log(res);
    
            resetOptions();
            createDisableOpt();
            for(var i=0; i < res[chosenBand].length; i++) {
                console.log(res[chosenBand][i]);
                fillArtistOpt(res[chosenBand][i].name);
            }

            artistOptions.onchange = function() {
    
                for(var i=0; i < res[chosenBand].length; i++) {
                    for(var a in res[chosenBand][i]) {
                        if(res[chosenBand][i][a] === artistOptions.value) {
                            // console.log(res[chosenBand][i]);
                            open(res[chosenBand][i].value, "_blank")
                        }
                    }
                }
            
            }
        })

        .catch((err) => {
            console.log(err);
        })

    // console.log(chosenBand);
}); */


function resetOptions() {
    
    var optLength = artistOptions.options.length;
    for(var i= optLength-1; i >=0; i--) {
        artistOptions.options[i] = null;
    }

}

function createDisableOpt() {
    var disabled = document.createElement('option');
    disabled.appendChild(document.createTextNode("Please Select"));
    disabled.value='Please Select';
    artistOptions.appendChild(disabled);
    disabled.classList.add('selected');
    disabled.classList.add('disabled');
}

function fillArtistOpt(artist) {
    // var artistOptions = document.getElementById('artists');

    var newArtist = document.createElement('option');
    newArtist.appendChild(document.createTextNode(artist));
    newArtist.value = artist;
    // newArtist.classList.add = band;
    artistOptions.appendChild(newArtist);
    
    return artistOptions;
}



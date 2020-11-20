document.getElementById('form').addEventListener('submit', function() {
    SaveUserInfo();
})

function SaveUserInfo() {
    // var count = 0;
    debugger;

    var name = document.getElementById('usrName').value;

    var age = document.getElementById('usrAge').value;

    var gender = document.getElementsByName('gender');

    var usrGender;

    for(var i=0; i< gender.length; i++) {
        if(gender[i].checked) {
            usrGender = gender[i].value;
        }
    }

    var options = document.getElementsByTagName('option');

    var usrFavColor;

    for(var i=0; i< options.length; i++) {
        if(options[i].selected) {
            usrFavColor = options[i].value;
        }
    }

    var date = new Date;
    date.setMonth(date.getMonth() + 1);

    setCookie("username", name, date);
    setCookie("gender", usrGender, date);
    setCookie("userAge", age, date);
    setCookie("favColor", usrFavColor, date);
    // setCookie('count', count, date)
    // return countVisitedTimes();
 
}

function countVisitedTimes() {
    var date = new Date;
    date.setMonth(date.getDay() + 20);
    var count;
    if(hasCookie('count')) {
        
        count = getCookie('count');
        var newCount = parseInt(count) + 1;
        deleteCookie('count');
        setCookie('count', newCount, date);
    } else {
        count = 1;
        setCookie('count', count, date);
    }
    // var count = getCookie('count');
    // console.log(count);
    // // var name = SaveUserInfo();
    // var date = new Date;
    // date.setMonth(date.getDay() + 20);
    // if(count === undefined) {
    //     console.log(count);
    //     count = 1;
    //     console.log( typeof count);
    //     setCookie('count', count, date);
    //     console.log(count);

    // } else {
    //     var newCount = parseInt(count) + 1;
    //     console.log(newCount);
    //     deleteCookie('count');
    //     setCookie('count', newCount, date);
    // }

    return (count == 1) ? count + " time :)" : count + " times :)";
}

function displayInfo() {

   
    var name = getCookie('username');
    var gender = getCookie('gender');
    var favColor = getCookie('favColor');
    var newDiv= document.createElement('div');
    
    document.body.appendChild(newDiv);

    var userProfile = document.createElement('img');
    userProfile.src = (gender === 'male') ? "./images/1.jpg" : "./images/2.jpg";

    var newP = document.createElement('p');

    var nameSpan = document.createElement('span');
    nameSpan.appendChild(document.createTextNode(name));
    var timesSpan = document.createElement('span');
    timesSpan.appendChild(document.createTextNode(countVisitedTimes()));

  
    newDiv.appendChild(userProfile);
    newDiv.appendChild(newP.appendChild(document.createTextNode("Welcome, ")));
    newDiv.appendChild(nameSpan);
    newDiv.appendChild(newP.appendChild(document.createTextNode(" You have Visited this site ")));
    newDiv.appendChild(timesSpan);
    
    nameSpan.style.color = favColor;
    timesSpan.style.color = favColor;
    
    // var val = document.cookie.split(';');
    
    // var h = document.createElement('h1');
    // h.appendChild(document.createTextNode(val));
   
    // document.body.appendChild(h);
}


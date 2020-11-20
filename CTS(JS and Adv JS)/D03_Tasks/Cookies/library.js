function setCookie(cookieName, cookieValue, expireDate) {

    try{
        if((cookieName === undefined) || (expireDate === undefined)) {
            throw new Error("Missing Parameter!");
        }
        //create cookies
        document.cookie = cookieName + "=" + cookieValue + ";expires=" + expireDate;

    }
    catch(e) {
        if(e.message === "Missing Parameter!") {
            console.log("You can't skip using cookieName or an expire date as parameters!");
        }
    }
    // document.cookie ="userAge=" + age + ";expires=" + date;

    // document.cookie = "gender=" + usrGender + ";expires=" + date;

    // document.cookie = "favColor=" + usrFavColor + ";expires=" + date;
    //"username=eslam; userAge=54; gender=female; favColor=blue"

}

function allCookieList() {
    
    var cookiesList = [];
    var splittedCookies = document.cookie.split(';');
    // cookieList.split(";")[0].split('=')[1]
    for(var i=0; i < splittedCookies.length; i++) {
        cookiesList[splittedCookies[i].split('=')[0].trim()] = 
        splittedCookies[i].split('=')[1];
    }

    return cookiesList;

}

function getCookie(cookieName) {
    
    try{
        if(cookieName === undefined) {
            throw new Error("Missing Parameter!");
        }
        var all = allCookieList();

    }
    catch(e) {
        if(e.message === "Missing Parameter!") {
            console.log("You have to enter a cookieName");
        }
    }
    

    return all[cookieName];
}

function deleteCookie(cookieName) {
    try{
        if(cookieName === undefined) {
            throw new Error("Missing Parameter!");
        }
        var all = allCookieList();
        for(c in all) {
            if(c === cookieName) {
                document.cookie = c + ";expires=1-1-2000";
            }
        }

    }
    catch(e) {
        if(e.message === "Missing Parameter!") {
            console.log("You have to enter a cookieName");
        }
    }

    
}

function hasCookie(cookieName) {
    try{
        if(cookieName === undefined) {
            throw new Error("Missing Parameter!");
        }
        var all = allCookieList();
        for(c in all) {
            if (c === cookieName) {
                return true;
            }
        }
    }
    catch(e) {
        if(e.message === "Missing Parameter!") {
            console.log("You have to enter a cookieName");
        }
    }
    
}

var range = document.getElementById('colorVal');
var div = document.getElementById('div');
var valDiv = document.getElementById('value');

div.style.border = '1px solid grey';
div.style.width = '90%';
div.style.height = '200px';
valDiv.innerHTML = 'Value = ' + range.value;

range.oninput = function() {
    // console.log(range.value);
    valDiv.innerHTML = 'Value = ' + range.value;
    div.style.backgroundColor = `rgb(${Math.floor(Math.random() * range.value)}%,${Math.floor(Math.random() * range.value)}%,${Math.floor(Math.random() * range.value)}%)`;
}



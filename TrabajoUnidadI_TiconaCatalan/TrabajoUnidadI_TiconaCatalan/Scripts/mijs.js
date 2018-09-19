window.onload = function () {
    iniciar();
}

function iniciar() {
    Concurrent.Thread.create(myMove);
    Concurrent.Thread.create(myMove2);
}

function myMove() {
    var velA = document.getElementById('velA').value;
    var velB = document.getElementById('velB').value;

    var elem = document.getElementById("myAnimation");
    var pos = 0;
    var vel = (velA > velB) ? 8 : 12;
    console.log("vel 1" + vel);
    var id = setInterval(frame, vel);
    function frame() {
        if (pos == 350) {
            clearInterval(id);
        } else {
            pos++;
            elem.style.right = pos + 'px';
            elem.style.left = pos + 'px';
        }
    }
}
function myMove2() {
    var velA = document.getElementById('velA').value;
    var velB = document.getElementById('velB').value;

    var elem = document.getElementById("myAnimation2");
    var pos = 0;
    var vel = (velB > velA) ? 8 : 12;
    console.log("vel 2" + vel);
    var id = setInterval(frame, vel);
    function frame() {
        if (pos == 350) {
            clearInterval(id);
        } else {
            pos++;
            elem.style.right = pos + 'px';
            elem.style.left = pos + 'px';
        }
    }
}
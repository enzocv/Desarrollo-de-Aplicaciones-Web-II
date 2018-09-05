var MovRaton = 0
var MovRaton2 = 0

function CambiaPosicion() {
    MovRaton = (MovRaton + 1) % 10
    if (MovRaton == 0) {
        Boton.style.top = window.event.y - Math.random() * 30 - Boton.clientHeight - 10
        Boton.style.left = window.event.x - Math.random() * 30 - Boton.clientWidth - 10
    }
    MovRaton2 = (MovRaton2 + 1) % 10
    if (MovRaton2 == 0) {
        Boton2.style.top = window.event.x - Math.random() * 30 - Boton2.clientHeight - 10
        Boton2.style.left = window.event.y - Math.random() * 30 - Boton2.clientWidth - 10
    }
}
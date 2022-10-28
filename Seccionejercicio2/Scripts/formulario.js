'use strict'

alert('si estoy cargando')

var form = document.forms['form'];
form.onsubmit = funcion(e){
    e.preventDefault();
    var select = document.form.tipo.value;
    console.log(select);
}
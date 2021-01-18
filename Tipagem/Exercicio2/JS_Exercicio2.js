var numeros = [ 4, 7, 17, 9, 79, 95, 4, 66, 36, 17, 70, 51, 24, 35, 65, 64, 60, 19, 27, 1 ];
var letras = ['V','Q','P','U','S','E','B','I','J','C','N','Z','X','T','F','A','K','W','L','Y'];

function MaiorElemento(array){
    //console.log(array[0])
    if(typeof(array[0])=="string"){
        array.sort()
        console.log(array[array.length - 1])
    }
    else console.log(Math.max.apply(null, array))
}

MaiorElemento(numeros)

//function apresentarprograma (nome) {console.log("Olá ", nome, "\nNeste programa iremos fazer uma demonstração das 4 operações básicas:")}

function somar (sm1, sm2) { console.log ('Resultado da soma: ' , sm1 + sm2) }

function subtrair (sub1, sub2) { console.log ('Resultado da subtração: ', sub1 - sub2)}

function multiplicar (mul1, mul2) {console.log ('Resultado da multiplicação: ', mul1*mul2)}

function dividir (div1,div2) {console.log ('Resultado da divisão: ', div1/div2)}
    
function calcular (operacao, elemento1, elemento2){
    console.log (operacao(elemento1, elemento2))
}

const numeros = [3854, 6523, 2856, 438, 39564, 2756, 1209127, 593]
//const nome = 'Guilherme';

calcular(somar, numeros[0], numeros[1])
calcular(subtrair, numeros[2], numeros[3])
calcular(multiplicar, numeros[4], numeros[5])
calcular(dividir, numeros[6], numeros[7])
function somar (arrayemquestao){
    //console.log(arrayemquestao.length)
    if (arrayemquestao.length == 1){
        //console.log("Passouaqui")
        return arrayemquestao[0]
    } 
    else {
        //console.log("passouaqui2")
        var novoarray = arrayemquestao.slice(1)
       // console.log(novoarray)
        //console.log(arrayemquestao)
        var soma
        soma = arrayemquestao[0] + somar(novoarray)
        //console.log(soma)
        return soma
    }


}
const F = [181, 82, 192, 104, 65, 75, 57, 156, 92, 69, 147, 142, 184, 134, 155]
console.log(somar (F))

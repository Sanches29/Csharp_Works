function impares (arrayemquestao){
    if (arrayemquestao.length == 1){
       // console.log("cheguei")
        if((arrayemquestao[0]%2) != 0){
         return arrayemquestao
        }
         else{
             arrayemquestao.splice(0,1) //splice add/remove itens do array (posição,quantidade)
         return arrayemquestao
         }
    }

    else{
        //console.log("passeinoelse")
        var novoarray = arrayemquestao.slice(1)
        novoarray = impares(novoarray)
        var pegarprimeiro
        if((arrayemquestao[0]%2) != 0){
           pegarprimeiro = arrayemquestao.slice(0,1)
           return pegarprimeiro.concat(novoarray)
        }
        else{
            return novoarray
        }
    }
}

const F = [181, 82, 192, 104, 65, 75, 57, 156, 92, 69, 147, 142, 184, 134, 155]
console.log (impares(F))

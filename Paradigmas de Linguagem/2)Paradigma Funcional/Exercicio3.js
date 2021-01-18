function power (arrayemquestao){
    if (arrayemquestao.length == 1){
        //console.log("cheguei")
        arrayemquestao[0] = Math.pow(arrayemquestao[0],2)
        //console.log(arrayemquestao)
        return arrayemquestao
    }

    else{
        novoarray = arrayemquestao.slice(1)
        novoarray = power (novoarray)
        //console.log(novoarray)
        var juntararray = []
        arrayemquestao[0] = Math.pow(arrayemquestao[0],2)
        //console.log(arrayemquestao) 
        var pegarprimeiro = arrayemquestao.slice(0,1)
        //console.log(pegarprimeiro)
        //juntararray = novoarray.concat(arrayemquestao[0])
        juntararray = pegarprimeiro.concat(novoarray)
        //console.log(juntararray)
        return juntararray
    }
    
}

const F = [181, 82, 192, 104, 65, 75, 57, 156, 92, 69, 147, 142, 184, 134, 155]
console.log(power(F))

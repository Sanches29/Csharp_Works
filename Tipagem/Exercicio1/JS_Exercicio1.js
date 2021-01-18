
    console.log("Olá Mundo");
    var palavras = ["a", "ama", "ralar", "aprovado", "rodador", "reter", "aprenda", "selecionado", "mussum"]
    var numeros = [1232, 121, 96235, 72627, 801108, 523925, 9, 865568]
     
    function serPalindromo(item){
        for(var i = 0; i < item.length; i++){
          if (typeof(item[i]) == "number") item[i] = item[i].toString()
          var separarLetras = item[i].split('')
          var reversoLetras = separarLetras.reverse()
          var unirLetras = reversoLetras.join('')
          if (item[i] == unirLetras) console.log ("O item " + item[i] + " é palindromo!" )
          else console.log("O item " + item[i] + " não é palindromo")
          
        }
    }
    serPalindromo(numeros)

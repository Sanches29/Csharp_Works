const F = [181, 82, 192, 104, 65, 75, 57, 156, 92, 69, 147, 142, 184, 134, 155]

var x = F.filter(function impar(item){
    if ((item%2) == 0){
        return null
    }
    else {
        return item
    }
})
 
console.log(x)
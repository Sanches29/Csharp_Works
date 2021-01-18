
function SeqFibo (enesimo){
    if ((enesimo == 2) || (enesimo== 1)){
        return 1;
    }
    else {
      return  SeqFibo(enesimo-1) + SeqFibo(enesimo-2)
    }
}

console.log (SeqFibo (5))


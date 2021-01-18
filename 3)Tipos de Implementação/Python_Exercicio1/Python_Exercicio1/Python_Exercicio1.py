import timeit

print("Este programa retornara a soma dos numeros de 1 a 1000000")
starttime = timeit.default_timer()

x = 0
for i in range(1000001):
	x += i
print("The time difference is :", timeit.default_timer() - starttime , "seconds")
print("O resultado da soma é: ", x)

# outra forma possivel seria:
starttime = 0 
starttime = timeit.default_timer()
y=0
i=0
while(i <= 1000000):
	y+=i
	i+=1
else:
	print("The time difference 2 is :", timeit.default_timer() - starttime , "seconds")
	print("O resultado da soma é: ", y)



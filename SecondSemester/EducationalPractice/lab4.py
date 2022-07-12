N = int(input("Введите N: "))
x = []
k1 = 0

k2 = 0
s = 0

C = float(input("Введите C: "))
D = float(input("Введите D: "))

for i in range(N):
    x.append(float(input("x({}) = ".format(i))))

for i in range(N):
    if x[i] < 0 and i % 2 == 0:
        k1 += 1

    if C <= x[i] <= D:
        k2 += 1
        s += x[i]

print("Массив:", x)
    
print("Количество элементов:", k1)
print("Среднее арифметическое:", s / k2)

for i in range(N - 1, -1, -1):
    if x[i] % 1 == 0:
        x.remove(x[i])

print("Измененный массив:", x)
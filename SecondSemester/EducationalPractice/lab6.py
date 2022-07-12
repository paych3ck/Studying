X = []
N = int(input("Введите N: "))
s = 0
k = 0

for row in range(N):
    X.append([])

    for column in range(N):
        X[row].append(float(input("X({}, {}) = ".format(row, column))))

print("Исходная матрица: {}".format(X))

for row in range(N):
    for column in range(N):
        if X[row][column] % 1 != 0:
            s += X[row][column]
            k += 1

if k == 0:
    print("Ошибка.")

else:
    print("Среднее арифметическое: {}".format(s / k))

    for i in range(N):
        X[i][N - i - 1] = s / k

    print("Новая матрица: {}".format(X))
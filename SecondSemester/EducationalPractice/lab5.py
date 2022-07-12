X = []
X_new = []

n = int(input("Строк: "))
m = int(input("Столбцов: "))

for row in range(n):
    X.append([])

    for column in range(m):
        X[row].append(int(input("X({}, {}) = ".format(row, column))))

for row in range(1, n, 2):
    for column in range(m):
        element = X[row][column]

        if element < row + column:
            X_new.append(element)

print(X_new)
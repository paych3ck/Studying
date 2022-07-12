L = int(input("L = "))
M = int(input("M = "))

i = 1
P1 = 1
while i <= M:
    P1 *= ((i + 2 * M) / (i ** 2 + i))
    i += 1

k = 1
S = 0
while k <= M:
    S += ((2 * k + M ** 2) / (M + k + 1))
    k += 1

j = 0
P2 = 1
while j <= L:
    P2 *= ((j ** 2 + 2) / (j + 1))
    j += 1

y = P1 + S + P2
print("y = " + str(y))
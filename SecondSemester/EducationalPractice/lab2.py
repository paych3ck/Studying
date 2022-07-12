from math import *

x = int(input("x: "))
y = int(input("y: "))

b = (sqrt(abs(x + y))) / (x ** abs(y - 2))

a = b + x ** 2 if x > y else y ** 2 - b

print("a: " + str(a) + ", b: " + str(b))
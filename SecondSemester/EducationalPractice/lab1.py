from math import *

x = int(input("x: "))
y = int(input("y: "))

result = ((y**x) / (sqrt(x**2 + 4 * y + 1))) + sin((x + y) / (2 * x + 4)) + ((4 * y)**(1/3))

print("Результат: " + str(result))
'''
Создайте класс MyInt, который будет наследоваться от стандартных целых чисел Python. Единственное отличие этого класса должно заключаться в том, что при вызове функции print будет выводиться не просто значение числа, а строка:

Значение: N
где N - значение числа.

Пример:
a = MyInt(5)
print(a)
# Значение: 5
'''

class MyInt(int):        
    def __str__(self):
        return f"Значение: {self.__int__()}"
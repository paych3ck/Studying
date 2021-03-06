'''
Необходимо создать функцию strict, которая будет принимать два именованных аргумента, которые являются целыми числами: n и m, и возвращать их сумму. При этом если функция будет вызываться без названий аргументов, должна появляться ошибка.

Пример 1:
Дано: strict(n = 1, m = 2)
Результат: 3

Пример 2:
Дано: strict(n = 1, 2)
Результат: TypeError

Пример 3:
Дано: strict(1, 2)
Результат: TypeError
'''

class Answer:
    def strict(self, *, n, m):
        return n + m
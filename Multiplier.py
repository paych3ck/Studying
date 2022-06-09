'''
Напишите функцию multiplier, которая будет возвращать произведение всех членов массива arr.

Пример:
Дано: [1, 2, 3, 4, 5]
Результат: 120
'''

class Answer:
    def multiplier(self, arr):
        m = 1
        for num in arr:
            m *= num
        return m

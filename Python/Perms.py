'''
Дан список чисел arr. Написать функцию perms, которая возвращает список из кортежей со всеми возможными перестановками из исходных чисел.

Пример:
Дано: [1, 2, 3]
Результат: [(1, 2, 3), (1, 3, 2), (2, 1, 3), (2, 3, 1), (3, 1, 2), (3, 2, 1)]
'''

from itertools import permutations

class Answer:
    def perms(self, arr):
        return list(permutations(arr))
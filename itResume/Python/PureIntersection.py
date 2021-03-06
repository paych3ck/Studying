'''
Вам дано 2 набора чисел arr1 и arr2 в виде списка Python. Необходимо вернуть список, состоящий из элементов пересечения. Дубликаты необходимо удалить.

Задание
Напишите функцию PureIntersection, которая будет возвращать список с уникальными элементами пересечения.

Функция PureIntersection принимает на вход:
arr1 - первый список с числами
arr2 - второй список с числами
Важно: Если пересечение пустое, то возвращаем пустой список.

Пример:
arr1 = [1, 2, 3], arr2 = [1, 1, 5]
Ответ: [1]

Пример:
arr1 = [1, 2, 3], arr2 = [6, 7, 5]
Ответ: []

Пример:
arr1 = [1, 2, 3], arr2 = [1, 2, 15, 3, 3]
Ответ: [1, 2, 3]
'''

class Answer:
    def PureIntersection(self, arr1, arr2):
        res = list(set(arr1).intersection(set(arr2)))
        return res
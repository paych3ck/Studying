'''
Эта задача взята с Avito Weekend Offer для аналитиков
Вам дан набор чисел в виде списка Python. Необходимо найти медиану этого числового ряда.

Задание
Напишите функцию FindMedian, которая будет возвращать одно число - медианное значение.

Функция FindMedian принимает на вход arr - исходный список с числами.

Пример:
arr = [1, 5, 2, 3, 6]
Ответ: 3

Пример:
arr = [100, 5, 2, 4, 3, 6]
Ответ: 4.5
Примечание: Если в выборке четное число элементов, то за медиану нужно взять среднее между центральными элементами (после упорядочивания).
'''

import math

class Answer:
    def FindMedian(self, arr):
        arr.sort()
        arr_len = len(arr)
        
        if arr_len == 0:
            return None

        elif arr_len % 2 == 0:
            res = (arr[int(arr_len / 2 - 1)] + arr[int(arr_len / 2)]) / 2
            
        else:
            res = arr[math.floor(arr_len / 2)]

        return res

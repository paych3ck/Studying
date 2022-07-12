'''
Дано целое число n. Найти разницу между произведение и суммой цифр в записи числа n.

Пример:
Дано: 128
Результат: 5
Объяснение: 1*2*8 - (1+2+8) = 16 - 11 = 5
'''

from math import prod

class Answer:
    def subtractProductAndSum(self, n):
        il = [int(numb) for numb in str(n)]
        return prod(il) - sum(il)
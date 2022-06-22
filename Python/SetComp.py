'''
Дано два множества: st1 и st2. Написать функцию set_comp, которая будет возвращать True, если st1 и st2 не имеют общих элементов и False иначе.

Пример 1:
Дано: st1 = {1, 2, 3}, st2 = {2, 3, 4}
Результат: False

Пример 2:
Дано: st1 = {1, 2, 3}, st2 = {20, 30, 40}
Результат: True
'''

class Answer:
    def set_comp(self, st1, st2):
        return not st1.intersection(st2)
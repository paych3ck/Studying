'''
Создайте класс Counter. При создании объекта данного класса должен инициализироваться счетчик value со значением 0.
В классе должны быть определены 2 метода - inc и dec. Метод inc должен увеличивать значение value на 1, а метод dec - уменьшать на 1.
Затем создайте класс-наследник NonDecreasingCounter, в котором операция dec не будет совершать никаких действий, а операция inc останется той же.

Пример:
cntr = NonDecreasingCounter()

cntr.inc()
# 1
cntr.inc()
# 2
cntr.dec()
# 2
'''

class Counter:
    def __init__(self):
        self.value = 0
        
    def inc(self):
        self.value += 1
        
    def dec(self):
        self.value -= 1

class NonDecreasingCounter(Counter):
    def dec(self):
        pass
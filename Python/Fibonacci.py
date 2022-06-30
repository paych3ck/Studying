'''
Дано целое число n. Написать функцию-генератор fibonacci, которая будет возвращать n первых чисел Фиббоначи при вызове метода next.

Пример:
Дано: n = 5

Результат:
res = fibonacci(5)
next(res)
# 1
next(res)
# 1
next(res)
# 2
next(res)
# 3
next(res)
# 5
'''

class Answer:
    def fibonacci(self, n):
        res = []
        
        for n in range(1, n + 1):
            if n in [1, 2]:
                res.append(1)
                
            else:
                res.append(res[n - 2] + res[n - 3])
            
        return res
'''
Дан массив nums, в котором содержится n+1 чисел в промежутке [1, n]. В массиве nums есть только одно число, которое повторяется несколько раз. Выведите это число.

Пример:
Дано: nums = [1,2,4,3,2]
Результат: 2
'''

class Answer:
    def findDuplicate(self, nums):
        s = set()
        
        for n in nums:
            if n in s:
                return n
           
            s.add(n)
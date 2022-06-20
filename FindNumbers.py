'''
Дан массив целых чисел nums. Найти количество чисел, у которых четное число цифр в записи числа.

Пример:
Дано: nums = [12,345,2,6,7896]
Результат: 2
'''

class Answer:
    def findNumbers(self, nums):
        count = 0
        for i in range(len(nums)):
            if len(str(nums[i])) % 2 == 0:
                count += 1
        return count
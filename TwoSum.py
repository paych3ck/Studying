'''
Дан массив целых чисел nums и целое число target. Вернуть индексы 2 чисел из массива nums, которые в сумме дают число target. Если target можно получить несколькими способами, то в качестве результата вернуть только один.

Пример:
Дано: nums = [2,7,11,15], target = 9
Результат: [0,1]
'''

class Answer:
    def twoSum(self, nums, target):
        for i in range(len(nums) - 1):
            if nums[i] + nums[i + 1] == target:
                indx1 = i
                indx2 = i + 1
        return [indx1, indx2]
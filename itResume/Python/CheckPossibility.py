'''
Дан массив целых чисел nums. Нужно проверить: можно ли сделать из nums неубывающий массив, изменив не более одного элемента.

Примечание: Неубывающий массив - массив, у которого каждый следующий элемент больше или равен предыдущему.

Пример 1:
Дано: nums = [4,2,3]
Результат: true
Объяснение: Мы можем заменить 4 на 1 и получить неубывающий массив.

Пример 2:
Дано: nums = [4,2,1]
Результат: false
Объяснение: Мы не можем получить неубывающий массив с помощью замены всего 1 элемента.
'''

class Answer:
    def checkPossibility(self, nums):
        count = 0
        for i in range(len(nums) - 1, 0, -1):
            if nums[i] < nums[i - 1]:
                count += 1
                nums[i - 1] = nums[i] - 1
                
            if count > 1:
                return False
            
        return True
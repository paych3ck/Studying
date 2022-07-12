'''
Дан массив целых чисел nums размерности 2n. Элементы массива расположены в следующем порядке: [x1,x2,...,xn,y1,y2,...,yn]. Необходимо преобразовать массив к виду [x1,y1,x2,y2,...,xn,yn].

Пример:
Дано: nums = [2,5,1,3,4,7], n = 3
Результат: [2,3,5,4,1,7]
'''

class Answer:
    def shuffle(self, nums, n):
        y1 = nums.pop(n)
        y2 = nums.pop(n)
        xn = nums.pop(n - 1)
        nums.insert(1, y1)
        nums.insert(3, y2)
        nums.insert(nums[-2], xn)
        return nums
'''
Реализуйте сортировку массива пузырьком.
'''

class Answer:
    def bubble_sort(self, nums):
        for i in range(1, len(nums)):
            for j in range(0, len(nums) - i):
                if nums[j] > nums[j + 1]:
                    nums[j], nums[j + 1] = nums[j + 1], nums[j]
        return nums
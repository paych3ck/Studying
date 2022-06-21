'''
Дан массив целых чисел candies, на i месте в котором находится количество конфет у i ребенка. Также дано целое число extraCandies. Необходимо для каждого ребенка проверить: если дать ему extraCandies, будет ли у него больше всего конфет?

Примечание: Одновременно может быть несколько детей с одинаково большим количеством конфет.

Пример 1:
Дано: candies = [2,3,5,1,3], extraCandies = 3
Результат: [true,true,true,false,true]

Пример 2:
Дано: candies = [12,1,12], extraCandies = 10
Результат: [true,false,true]
'''

class Answer:
    def kidsWithCandies(self, candies, extraCandies):
        m = max(candies)
        
        for i in range(len(candies)):
            candies[i] = candies[i] + extraCandies >= m
                       
        return candies
'''
Задание
Напишите функцию fizzbuzztest, которая возвращает массив, который формируется по следующим правилам:

Обрабатываются числа от 1 до 100
Если число кратно трем, то в массив заносим слово Fizz
Если число кратно пяти, то в массив заносим слово Buzz
Если число кратно и трем, и пяти, то в массив заносим слово FizzBuzz
Если число не кратно ни одному их этих чисел, то в массив нужно поместить просто само число
Примечание: Массив чисел для обработки задавайте непосредственно внутри функции - функция не принимает аргументы.

Пример:
Дано: [1, 2, 3, 4, 5...15...]
Результат: [1, 2, Fizz, 4, Buzz, ... FizzBuzz, ...]
'''

class Answer:
    def fizzbuzztest(self):
        array = []
        
        for number in range(1, 101):
            if number % 15 == 0:
                array.append("FizzBuzz")
                
            elif number % 3 == 0:
                array.append("Fizz")
            
            elif number % 5 == 0:
                array.append("Buzz")
            
            else:
                array.append(number)
                
        return array
      
print(Answer().fizzbuzztest())
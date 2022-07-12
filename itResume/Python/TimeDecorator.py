'''
Напишите декоратор TimeDecorator, который будет замерять время выполнения декорированной функции. Исходная функция должна возвращать результат, а декоратор должен просто выводить строку "Затрачено N секунд" на экран.

Пример:
def func(...):
  ... 
  print('Я закончила работать!')

func()
# Затрачено 0.5 секунд
# Я закончила работать!
'''

import time

class Answer:
  def TimeDecorator(self, func):
      def wrapper(*args, **kwargs):
          start = time.time()
          res = func(*args, **kwargs)
          print(f"Затрачено {time.time() - start} секунд")
          return res
      return wrapper
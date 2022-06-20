'''
Создать декоратор SedativeDecorator, который будет запускать задекорированную функцию и выполнять одно из действий:

Если функция выполнилась без ошибок, то возвращать строку "Все ок"
Если во время выполнения фукнции возникла ошибка, то возвращать строковое представление ошибки
Пример:

> Функция отрабатывает нормально
func(1)
# Все ок

> Функция должна кинуть ValueError
func(2)
# 'ValueError'
'''

class Answer:
    def SedativeDecorator(self, func):
        def wrapper():
            try:
                func()
                return "Все ок"

            except Exception as xc:
                return repr(xc)

        return wrapper
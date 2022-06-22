'''
Задайте класс Person следующим образом:
при создании конструктор должен принимать на вход имя и записывать его в атрибут name
операция сложения («+») должна быть реализована таким образом, чтобы результатом была строка вида <name> и <добавляемое значение>

Пример:
me = Person('IT Resume')
print(me.name)
# IT Resume

print(me + 'Вы')
# IT Resume и Вы
'''

class Person:
    name = ""
    
    def __init__(self, name):
        Person.name = name
    
    def __add__(self, oth):
        return f"{Person.name} и {oth}"
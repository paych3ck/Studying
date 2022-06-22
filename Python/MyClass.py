'''
Создайте класс MyClass, в котором будет определен метод count, возвращающий количество созданных экземпляров данного класса. Должна быть предусмотрена возможность вызывать метод без создания экземпляра класса.

Пример:
obj1 = MyClass()
obj2 = MyClass()
obj3 = MyClass()

MyClass.count()
# 3
'''

class MyClass():
    counter = 0
    
    def __init__(self):
        MyClass.counter += 1
    
    @staticmethod
    def count():
        return MyClass.counter
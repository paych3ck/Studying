'''
Допиши программу. Определи метод area внутри класса, который возвращает значение площади. 
Программа должна запрашивать у пользователя ввод стороны квадрата и выводить на экран его площадь.
'''

class Square():
    @staticmethod
    def area(side):
        return side * side

figure = Square()
side_length = int(input("Введите длину стороны квадрата: "))
print(figure.area(side_length))
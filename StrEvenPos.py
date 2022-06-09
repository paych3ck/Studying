'''
На вход подается строка str. Напишите функцию even_pos, которая будет возвращать символы на четных позициях.

Пример:
Дано: 'abcdef'
Результат: 'ace'
'''

class Answer:
    def even_pos(self, str):
        new_string = ""
        
        for i in range(len(str)):
            if i % 2 == 0:
                new_string += str[i]
        
        return new_string

'''
Дано целое число, состоящее только из цифр 6 и 9. Найти максимальное число, которое можно получить, заменив одну цифру на другую.

Примечание: Если при замене получается число, меньше текущего, то замену делать не нужно.

Пример 1:
Дано: 6666
Результат: 9666

Пример 2:
Дано: 9699
Результат: 9999

Пример 3:
Дано: 9999
Результат: 9999
'''

class Answer:
    def maximum69Number(self, num):
        num_list = list(str(num))
        for i in range(len(num_list)):
            if num_list[i] == "6":
                num_list[i] = "9"
                break
        return int("".join(num_list))
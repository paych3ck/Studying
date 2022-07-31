'''
Программа должна запрашивать список — число участников в каждой команде через пробел, и выводить на экран тот же список в отсортированном по возрастанию виде. 
Важно: алгоритм обязательно должен работать на основе вложенных циклов for. Использование функций (в том числе стандартной функции sorted()) запрещено.
'''

members = list(map(int, input("Введите число участников в каждой команде через пробел:").split()))

for i in range(1, len(members)):
    for j in range(0, len(members) - i):
        if members[j] > members[j + 1]:
            members[j], members[j + 1] = members[j + 1], members[j]

print(members)
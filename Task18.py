#Задача 18. Требуется найти в массиве A[1..N] самый близкий 
#по величине элемент к заданному числу X. Пользователь в 
#первой строке вводит натуральное число N – количество элементов 
#в массиве. В последующих строках записаны N целых чисел Ai. 
#Последняя строка содержит число X.
n = int(input("Введите количество элементов N в массиве: "))
array = []
res = 0
print("Введите элементы массива:")

for i in range(n):
    array.append(int(input()))

x = int(input("Введите искомое число X в массиве: "))

for i in range(1, n):
    if array[i-1] - x < array[i] - x:
        res = array[i-1]

print("Введённый массив:")
print(array)
print(f"Самый близкое по величине число к {x} в массиве: {res}")
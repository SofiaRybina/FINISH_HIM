Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Решение:
Задаём два массива.
Первый - задан на старте выполнения. Второй - такой же длины что и первый.
Создаём метод ResultNewArray, который пробежит по первому массиву столько раз сколько длина первого массива.
Внутри метода добавим проверку условия (<=3), если условие выполняется элемент первого массива заносится в count - элемент второго массива. После присвоения count увеличивается на 1 и возвращается к циклу for в котором i увеличивается на 1. Переходим на следующую итерацию, повторяем пока не пробежимся по всем элементам первого массива.
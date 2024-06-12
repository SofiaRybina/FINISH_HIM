/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

string[] arr_1 = new string[5] {"1234", "1567", "-2", "computer science", ":-)"};
string[] arr_2 = new string[arr_1.Length];


void ResultNewArray(string[] arr_1, string[] arr_2)
{
    int count = 0;
    for (int i = 0; i < arr_1.Length; i++)
    {
    if(arr_1[i].Length <= 3)
        {
        arr_2[count] = arr_1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ResultNewArray(arr_1, arr_2);
Console.Write($"Задан массив: ");
PrintArray(arr_1);
Console.Write($"Результат: ");
PrintArray(arr_2);
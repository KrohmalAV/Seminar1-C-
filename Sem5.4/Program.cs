/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/


int[] FillArray(int size, int min, int max)  // Заполнение массива (рандомно)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) array[i] = new Random().Next(min, max);
    return array;
}
void PrintArray(int[]array)  // Вывод массива
{
    Console.Write($"[{array[0]}");
    for(int i = 1; i < array.Length; i++) Console.Write($", {array[i]}");
    Console.WriteLine("]");
}
int CountFindNum(int[]array, int min, int max) // Поиск элементов массива лежащих в диапазоне
{
    int count = 0;
    foreach(int arr in array)
        if(arr >= min && arr <= max) count++;
    return count;
}

Console.Clear();
int[] array = FillArray(123, 0, 1000);
PrintArray(array);
int count = CountFindNum(array, 10, 99);
Console.WriteLine($"В отрезке [10,99] лежат {count} элементов массива");
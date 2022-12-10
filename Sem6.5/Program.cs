/*
 Задача 45: Напишите программу, которая будет
 создавать копию заданного массива с помощью
 поэлементного копирования.
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
int[] DuplicatedArray(int[]array) // Новый массив копирующий первый массив поэлементно
{
    int[] arr = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        arr[i] = array[i]; 
    return arr;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(len, -10, 10);
Console.Write("Первый массив: ");
PrintArray(array);
int[] duplicatedArray = DuplicatedArray(array);
Console.Write("Второй (дублированный) массив: ");
PrintArray(duplicatedArray);
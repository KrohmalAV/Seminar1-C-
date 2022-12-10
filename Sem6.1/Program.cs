/*
Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом месте,
а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/


int[] FillArray(int size, int min, int max)  // Заполнение одономерного массива (рандомно)
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
int[] NewArray(int[]array) // Новый массив обратный первому
{
    int[] arr = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        arr[i] = array[^(i+1)]; 
    return arr;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(len, 0, 10);
PrintArray(array);
int[] arr = NewArray(array);
PrintArray(arr);
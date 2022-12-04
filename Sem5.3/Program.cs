/*
Задача 33: Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) array[i] = new Random().Next(min, max);
    return array;
}
void PrintArray(int[]array)
{
    Console.Write($"[{array[0]}");
    for(int i = 1; i < array.Length; i++) Console.Write($", {array[i]}");
    Console.WriteLine("]");
}
bool FindNum(int[]array, int A)
{
    bool flag = false;
    foreach(int arr in array)
    {
        if(arr == A)
        {
            flag = true;
            break;
        }
    }
    return flag;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size, -9, 10);
PrintArray(array);
Console.Write($"Введите искомое число: ");
int A = Convert.ToInt32(Console.ReadLine());
bool flag = FindNum(array, A);
if(flag) Console.WriteLine($"В массиве имеется число {A}");
else Console.WriteLine($"В массиве нет числа {A}");
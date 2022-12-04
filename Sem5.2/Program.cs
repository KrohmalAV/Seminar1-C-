/*
Задача 32: Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные,
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

Console.Clear();
void FillArray(int[]array)
{
    for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(-9, 10);
}
void PrintArray(int[]array)
{
    Console.Write($"[{array[0]}");
    for(int i = 1; i < array.Length; i++) Console.Write($", {array[i]}");
    Console.Write("]");
}
void RepArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = -array[i];
}

int[] array = new int[6];
FillArray(array);
PrintArray(array);
RepArray(array);
Console.WriteLine();
PrintArray(array);
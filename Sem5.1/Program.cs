/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными
числами из промежутка [-9, 9]. Найдите сумму отрицательных и
положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
сумма положительных чисел равна 29, сумма отрицательных равна -20.
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
int CountPos(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count += array[i];
    }
    return count;
}
int CountNeg(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) count += array[i];
    }
    return count;
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
int NumPos = CountPos(array);
int NumNeg = CountNeg(array);
Console.WriteLine($"\nСумма положительных чисел - {NumPos}");
Console.WriteLine($"Сумма отрицательных чисел - {NumNeg}");

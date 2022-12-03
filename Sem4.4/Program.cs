/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Console.Clear();
void FillArray(int[]array)
{
    for(int i = 0; i < 8; i++) array[i] = new Random().Next(0, 2);
}
void PrintArray(int[]array)
{
    for(int i = 0; i < 8; i++) Console.Write($"{array[i]} ");
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);

// Без функций
// Console.Clear();
// int[] array = new int[8];
// for(int i = 0; i < 8; i++)
// {
//     array[i] = new Random().Next(0, 2);
//     Console.Write($"{array[i]} ");
// }
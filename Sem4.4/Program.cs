/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

// Console.Clear();
// void FillArray(int[]array)
// {
//     int i = 0;
//     while(i < 8)
//     {
//         array[i] = new Random().Next(0, 2);
//         i++;
//     }
// }
// void PrintArray(int[]col)
// {
//     int position = 0;
//     while(position < 8)
//     {
//         Console.Write($"{col[position]} ");
//         position++;
//     }
// }
// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);

// Без функций
Console.Clear();
int[] array = new int[8];
for(int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write($"{array[i]} ");
}
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

int[] array = new int[5];
FillArray(array);
PrintArray(array);
int[] arr = array;
RepArray(arr);
Console.WriteLine();
PrintArray(arr);






// int[] arr = new int[12];
// for (int i = 0; i < 12; i++)
//   arr[i] = new Random().Next(-9, 10);
// PrintArray(arr);
// Console.WriteLine();
// Convert(arr);
// PrintArray(arr);

// void PrintArray(int[] array)
// {
//   Console.Write($"[{array[0]}");
//   for (int i = 1; i < 12; i++) Console.Write($", {array[i]}");
//   Console.Write("]");
// }

// void Convert(int[] array)
// {
//   for (int i = 1; i < 12; i++) array[i]=-array[i];
// }
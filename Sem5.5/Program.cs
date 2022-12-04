/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
int[] NewArrayMulti(int[]array) // Новый массив из произведений пар чисел
{
    if(array.Length % 2 == 0)
    {    
        int[] arr = new int[array.Length/2];
        for(int i = 0; i < array.Length/2; i++)
            arr[i] = array[i] * array[^(i+1)];
    return arr;
    }
    else
    {
        int[] arr = new int[array.Length/2 + 1];
        for(int i = 0; i < array.Length/2; i++)
            arr[i] = array[i] * array[^(i+1)];
        arr[^1] = array[array.Length/2];
        return arr;
    }
}

Console.Clear();
int[] array = FillArray(7, 0, 10);
PrintArray(array);
int[] arr = NewArrayMulti(array);
PrintArray(arr);
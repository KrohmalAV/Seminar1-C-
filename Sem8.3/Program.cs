/*
Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается
элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза 
1 встречается 1 раз 
2 встречается 1 раз 
8 встречается 1 раз 
9 встречается 3 раза
1, 2, 3 
4, 6, 1 
2, 1, 6
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза

*/

int[,] FillDoubleArray(int row, int column, int min, int max)  // Заполнение двумерного массива (рандомно)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++) 
        for(int j = 0; j < column; j++)
            array[i,j] = new Random().Next(min, max);
    return array;
}

void PrintDoubleArray(int[,]array)  // Вывод двумерного массива
{
    for(int i = 0; i < array.GetLength(0); i++) 
        {
            for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
            Console.WriteLine(); 
        } 
}

int FrequencyArray(int[,]array)  // Частотный словарь элементов
{
    string count = string.Empty; 
    for(int i = 0; i < array.GetLength(0)/2; i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if (array[i,j] = 
    
    
    int[,] frequencyArray = new int[];
    
    

    return frequencyArray;
}

void PrintFrequencyArray(int[,]array)  // Вывод частотного массива
{
    int i = 0;
    for(int j = 0; j < array.GetLength(1); j++)
        Console.WriteLine($"{array[i,j]} встречается {array[1,j]} раз"); 
}
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = FillDoubleArray(row, column, 0, 10);
PrintDoubleArray(array);
int[,] frequencyArray = FrequencyArray(array);
PrintFrequencyArray(array);



/*
Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элемент для поиска: ");
int find = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[m, n];

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
            Console.Write($"{collection[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindNum(int[,] arr)
{
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == find)
            {
                index++;
            }
        }
    }
    Console.WriteLine(index);
}

FillArray(nums);
FindNum(nums);



Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
От Stanislav N всем 10:17 AM
Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/
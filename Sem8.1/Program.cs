/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет
местами первую и последнюю строку массива.
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

void ChangeStringArray(int[,]array)  // Обмен местами первой и последней строки
{
    int i = 0;
    for(int j = 0; j < array.GetLength(1); j++) 
        (array[i,j], array[array.GetLength(0)-1,j]) = (array[array.GetLength(0)-1,j], array[i,j]);
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = FillDoubleArray(row, column, 0, 10);
PrintDoubleArray(array);
ChangeStringArray(array);
Console.WriteLine("Новый массив:");
PrintDoubleArray(array);
/*
Задача 49: Задайте двумерный массив. Найдите элементы,
у которых оба индекса чётные, и замените эти элементы
на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
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

void RepElementsArray(int[,]array)  // Заполнение двумерного массива (рандомно)
{
    for(int i = 0; i < array.GetLength(0); i++) 
        for(int j = 0; j < array.GetLength(1); j++)
            if(i % 2 ==0 && j % 2 == 0)
                array[i,j] *= array[i,j];
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = FillDoubleArray(row, column, -9, 10);
PrintDoubleArray(array);
RepElementsArray(array);
Console.WriteLine();
PrintDoubleArray(array);
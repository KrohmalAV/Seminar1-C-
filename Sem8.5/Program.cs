/*
Задача 61: Вывести первые N строк треугольника Паскаля.
Сделать вывод в виде равнобедренного треугольника
*/

// Метод факториала
long Factorial (int num)
{
    long factorial = 1;
    for (long i = 1; i <= num; i++)
        factorial *= i;
    return factorial;
}

Console.Clear();
Console.Write("Введите количество строк треугольника Паскаля: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    Console.Write($"{i+1}");
    for (int j = 0; j <= (N - i); j++) 
        Console.Write(" "); 
    for (int j = 0; j <= i; j++)
        Console.Write($" {Factorial(i) / (Factorial(j) * Factorial(i - j))}");
    Console.WriteLine();
}


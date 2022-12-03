/*
Задача 28: Напишите программу, которая принимает на вход число N
и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

// Через метод
int Multi(int N)
{
    int pro = 1;
    for(int i = 1; i <= N; i++) pro = pro * i;
    return pro;
}

Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multi(N));


// Без метода
// Console.Clear();
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int pro = 1;
// for(int i = 1; i <= N; i++) pro = pro * i;
// Console.WriteLine(pro);

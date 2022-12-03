/*
Задача 26: Напишите программу, которая принимает на вход число
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

// Решение через метод
int Count(int A)
{
    int count = 0;
    while(A > 0)
    {
        A /= 10;
        count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В числе {A} - {Count(A)} цифр");


// Решение через строки
// Console.Clear();
// Console.Write("Введите число: ");
// string A = Console.ReadLine();
// int length = A.Length;
// Console.WriteLine($"В числе {A} - {length} цифр");

// Решение без использования строк и метода
// Console.Clear();
// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int a = A;
// while(a > 0)
// {
//     a /= 10;
//     count++;
// }
// Console.WriteLine($"В числе {A} - {count} цифр");
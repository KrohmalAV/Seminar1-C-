/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();
Console.Write("Введите количество чисел последовательности Фибоначчи: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) 
    Console.Write("Ошибка. Необходимо было ввести натуральное число.");
else if (number == 1) 
    Console.Write("Первое число последовательности Фибоначчи: 0");
else
{
    int[] numberFibbonachi = new int[number];
    numberFibbonachi[0] = 0;
    numberFibbonachi[1] = 1;
    for(int i = 2; i < number; i++)
        numberFibbonachi[i] = numberFibbonachi[i-1] + numberFibbonachi[i-2];
Console.Write($"Первые {number} числа последовательности Фибоначчи: ");
foreach(int num in numberFibbonachi)
    Console.Write($"{num} ");
}
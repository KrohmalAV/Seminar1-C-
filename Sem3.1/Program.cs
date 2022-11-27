/*
Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

Console.Clear();
Console.Write("Введите X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y: ");
double y = Convert.ToDouble(Console.ReadLine());
if(x > 0 && y > 0) Console.WriteLine ("I четверть");
else if(x > 0 && y < 0) Console.WriteLine ("IV четверть");
else if(x < 0 && y < 0) Console.WriteLine ("III четверть");
else if(x < 0 && y > 0) Console.WriteLine ("II четверть");
else Console.WriteLine ("Это центр координат");
Console.ReadKey();
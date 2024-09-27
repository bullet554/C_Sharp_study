// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату Х, кроме 0: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y, кроме 0: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X == 0 || Y == 0)
{
    Console.WriteLine("Одна из координат ровна нулю");
}
else
{
    if (X > 0 && Y > 0)
    {
        Console.WriteLine("1");
    }
    if (X < 0 && Y > 0)
    {
        Console.WriteLine("2");
    }
    if (X < 0 && Y < 0)
    {
        Console.WriteLine("3");
    }
    if (X > 0 && Y < 0)
    {
        Console.WriteLine("4");
    }
}
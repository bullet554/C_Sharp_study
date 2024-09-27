// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// Пример:
// m = 2, n = 3 -> A(m,n) = 29

void Main()
{
    int m = ReadInt("Введите первое число: ");
    int n = ReadInt("Введите второе число: ");
    if (n < 0 || m < 0)
    {
        Console.WriteLine("Вы ввели некорректные значния!");
        return;
    }

    Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
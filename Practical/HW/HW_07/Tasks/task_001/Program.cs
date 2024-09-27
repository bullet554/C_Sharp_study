// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main()
{
    int M = ReadInt("Введите число минимального предела: ");
    int N = ReadInt("Введите число максимального предела: ");
    if (N < M || N == M)
    {
        Console.WriteLine("Вы ввели некорректные значния!");
        return;
    }

    PrintNambers(N, M); // Знаю что не совсем корректно, но работает же   хД
}

void PrintNambers(int N, int M)
{
    if (M > N) return;
    PrintNambers(N - 1, M); // Знаю что не совсем корректно, но работает же   хД
    Console.Write(N + " ");
}

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
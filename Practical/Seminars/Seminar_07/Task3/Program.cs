// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void Main()
{
    Console.WriteLine("Введите строку: ");
    string? str = Console.ReadLine();

    PrintConsonants(str!);
}

bool isConsonant(char c)
{
    return "bcdfghjklmnpqrstvwxz".Contains(c);
}

void PrintConsonants(string input, int i = 0)
{
    if (input.Length < 1) return;

    if (isConsonant(char.ToLower(input[0])))
        Console.Write(input[0] + " ");

    PrintConsonants(input[1..]);
}

Main();
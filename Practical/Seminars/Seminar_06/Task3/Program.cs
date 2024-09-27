// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

void Main()
{
    System.Console.WriteLine("Введите текст: ");
    string? str = System.Console.ReadLine()!.ToLower();
    System.Console.WriteLine(CountVowels(str));
}

int CountVowels(string? str)
{
    int count = 0;
    foreach (char letter in str)
        if (isVowel(letter))
            count += 1;
    return count;
}

bool isVowel(char c)
{
    return "aeiouy".Contains(c);
}

void PrintCharArray(char[] c)
{
    System.Console.WriteLine("['" + string.Join("', '", c) + "']");
}

Main();
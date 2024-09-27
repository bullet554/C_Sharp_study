// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

// Пример:
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

void Main()
{
    Console.WriteLine("Введите текст: ");
    string str1 = Console.ReadLine()!.ToLower();
    string str2 = StringReversed(str1);
    Console.WriteLine(IsPalindrome(str1, str2));
}

string IsPalindrome(string str1, string str2)
{
    if (str1 == str2)
        return "Да";
    else
        return "Нет";
}

string StringReversed(string str1)
{
    string reversed = "";
    for (int i = str1.Length - 1; i >= 0; i--)
    {
        reversed += str1[i];
    }
    return reversed;
}

Main();
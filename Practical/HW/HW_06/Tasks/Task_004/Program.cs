// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.


// Пример:
// “Hello my world” => “world my Hello”


void Main()
{
    Console.WriteLine("Введите предложение: ");
    string? inputString = Console.ReadLine();
    string[] strSplit = StringSplit(inputString!);
    string reversedString = String.Join(" ", strSplit.Reverse());
    Console.WriteLine($"Результат: {reversedString}");
}

string[] StringSplit(string inputString)
{
    string[] stringArray = inputString!.Split();
    return stringArray;
}

Main();
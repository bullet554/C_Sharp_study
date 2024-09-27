// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

// Пример:
// a b c => “abcdef”
// d e f

void Main()
{
    char[,] letters = 
    {
        {'a', 'b', 'c'},
        {'d', 'e', 'f'}
    };

    string str = FromCharArrayToString(letters);
    Console.WriteLine(str);
}

string FromCharArrayToString(char[,] letters)
{
    string str = "";

    foreach (char letter in letters)
        str += letter;
    return str;
}

Main();
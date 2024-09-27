// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

void Main()
{
    string str = "Hello!";
    // 1-й способ (запрещен в условии):
    // char[] tempChar = str.ToCharArray();
    // PrintCharArray(tempChar);

    // 2-й способ:
    PrintCharArray(FromStringToCharArray(str));
}

    // 2-й способ:
char[] FromStringToCharArray(string str)
{
    char[] tempChar = new char[str.Length];

    for (int i = 0; i < str.Length; i++)
        tempChar[i] = str[i];

    return tempChar;
}

void PrintCharArray(char[] c)
{
    System.Console.WriteLine("['" + string.Join("', '", c) + "']");
}

Main();
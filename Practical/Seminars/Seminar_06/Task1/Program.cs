// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


void Main()
{
    char[] letters = {'a', 'b', 'c', 'd'};
    // 1-й способ (запрещен в условии задачи):
    // string str = new string(letters);

    // 2-й способ:
    // string str = FromCharArrayToString(letters); 

    // 3-й способ:
    // string str = string.Join("", letters); // Join объединяет все элементы с разделителем. В данном случае в разделителе пусто.

    // 4-й способ:
    string str = string.Concat(letters);  // Concat объединяет все элементы без разделителя.
    Console.WriteLine(str); 
}

// string FromCharArrayToString(char[] letters)
// {
//     string str = "";
    
//     foreach (char letter in letters)
//         str += letter;
    
//     return str;
// }

Main();
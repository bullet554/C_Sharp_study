﻿// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

// Пример:
// “aBcD1ef!-” => “abcd1ef!-” 

void Main()
{   
    Console.WriteLine("Введите текст: "); 
    string str = Console.ReadLine()!.ToLower();
    Console.WriteLine(str);
}

Main();
// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

void Main()
{
    while (true)
    {
        System.Console.Write("Введите число или 'q'  для выхлжа: ");
        string input = Console.ReadLine();

        if (input == "q" || input == " " || input == "")
            break;

        int number = Convert.ToInt32(input);
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        if (sum % 2 == 0)
            break;
    }
    System.Console.WriteLine("Конец программы!");
}
Main();

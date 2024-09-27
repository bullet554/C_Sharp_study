// Ctrl + Shift + P = autoSave

Console.WriteLine("Введите первое значение: ");
int firstValue = int.Parse(Console.ReadLine()); // Может вернуться пустая строка, если ввести не только цифры

Console.WriteLine("Введите второе значение: ");
int secondValue = Convert.ToInt32(Console.ReadLine()); // Защита от дурака. И код с терминалом чище :)

 if(firstValue == secondValue * secondValue)
 {
    Console.WriteLine("a = " + firstValue + ", b = " + secondValue + " => Да");
 }
 else
 {
    Console.WriteLine($"a = {firstValue}, b = {secondValue} => Нет");
 }
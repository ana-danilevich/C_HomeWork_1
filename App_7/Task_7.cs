/*Напишите программу, которая запрашивает у пользователя дробное число, округляет его до
ближайшего целого и выводит результат. Используйте методы класса Math для округления.*/
Console.Write("Введите дробное число: ");
string userNumber = Console.ReadLine();
double num = double.Parse(userNumber);
double roundedNumber = Math.Round(num);
Console.WriteLine($"Число {num} округлилось до {roundedNumber}");
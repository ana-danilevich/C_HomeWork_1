/*Напишите программу, которая запрашивает у пользователя два числа, выполняет над ними все
возможные арифметические операции (сложение, вычитание, умножение, деление) и выводит
результаты на экран.*/
Console.Write("Введите первое число: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Сложение: " + (firstNumber + secondNumber));
Console.WriteLine("Вычитание: " + (firstNumber - secondNumber));
Console.WriteLine("Умножение: " + (firstNumber * secondNumber));
Console.WriteLine("Деление: " + (firstNumber / secondNumber));
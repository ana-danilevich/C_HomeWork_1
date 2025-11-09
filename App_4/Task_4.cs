/*Напишите программу, которая принимает на вход два числа и сравнивает их. Используйте
операторы сравнения и выведите, какое число больше, меньше или равны ли они.*/
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool isEqual = firstNumber == secondNumber;
bool isGreater = firstNumber > secondNumber;
bool isLess = firstNumber < secondNumber;

if (isEqual)
{
    Console.WriteLine($"{firstNumber} равно {secondNumber}");
}
else if (isGreater)
{
    Console.WriteLine($"{firstNumber} больше {secondNumber}");
}
else
{
    Console.WriteLine($"{firstNumber} меньше {secondNumber}");
}
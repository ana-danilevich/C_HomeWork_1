/*Создайте программу, которая запрашивает у пользователя число в виде строки. Преобразуйте его
в тип int и выведите его квадрат на экран.*/
Console.Write("Введите чисто: ");
string userNumber = Console.ReadLine();
int num = int.Parse(userNumber);
int square = num * num;
Console.WriteLine($"Квадрат числа {num} равен {square}");
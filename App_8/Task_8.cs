/*Создайте программу, в которой вы используете определенные константы для расчета площади
круга и площади квадрата. Запросите необходимую информацию у пользователя и выведите
результаты.*/
const double PI = 3.1415926;
Console.Write("Введите радиус круга: ");
double radius = double.Parse(Console.ReadLine());
double areaOfACircle = PI * radius *  radius;
Console.Write("Введите площадь квадрата: ");
double squareSide = double.Parse(Console.ReadLine());
double areaOfASquare = squareSide * squareSide;
Console.WriteLine($"Площадь круга с радиусом {radius} равна {areaOfACircle}");
Console.WriteLine($"Площадь квадрата со стороной {squareSide} равна {areaOfASquare}");
// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1,  y = k2 * x + b2;
// значения b1, k1, b2 и k2 Задаются пользователем 


Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());


void IntersectionPoints(double k1, double b1, double k2,double b2)
{
    double x = 0;
    double y = 0;
    x = ((b2 - b1) / (k1 - k2));
    y = k1 * x + b1;
    Console.WriteLine($"Координаты пересечения: х = {x}, y = {y}");
}



IntersectionPoints(k1, b1, k2, b2);
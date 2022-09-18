// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Tochka(double a, double b, double c, double d)
{
    double t = (b*(c-a)/(b-d))+a;
    return t;
}

double Tochka2(double a, double b, double c, double d)
{
    double t = (d*(c-a)/(b-d))+c;
    return t;
}

Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Две прямые пересекутся в точке: {Tochka(b1,k1,b2,k2):f2}; {Tochka2(b1,k1,b2,k2):f2}");
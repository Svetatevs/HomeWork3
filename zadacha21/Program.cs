// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistanceAB(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return result;
}

Console.Write("Введите координату х точки А: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y точки А:  ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z точки А: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату x точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distance = FindDistanceAB(xA, yA, zA, xB, yB, zB);
Console.Write("Расстояние между точками АВ = ");
Console.WriteLine(Math.Round(distance,2)); 

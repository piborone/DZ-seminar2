// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("введите Х1 ");
int numbersX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите Y1 ");
int numbersY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите Z1 ");
int numbersZ1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите Х2 ");
int numbersX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите Y2 ");
int numbersY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите Z2 ");
int numbersZ2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Координаты точки А ({numbersX1}, {numbersY1}, {numbersZ1});");
Console.WriteLine($"Координаты точки В ({numbersX2}, {numbersY2}, {numbersZ2});");
double rezult = Math.Sqrt((Math.Pow(numbersX2-numbersX1,2))+(Math.Pow(numbersY2-numbersY1,2))+(Math.Pow(numbersZ2-numbersZ1,2)));
double coord = Math.Round(rezult, 2, MidpointRounding.AwayFromZero);
Console.WriteLine($"Расстояние между точками в 3D пространстве - {coord}");
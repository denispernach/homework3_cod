// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты X первой точки");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X второй точки");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(X2-X1, 2)+ Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2));
Console.WriteLine(result);





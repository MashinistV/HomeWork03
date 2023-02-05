//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
int x1;
int x2;
int y1;
int y2;
int z1;
int z2;
Console.WriteLine("Введите координаты первой точки");
Console.Write("X1 = ");
while (!int.TryParse(Console.ReadLine(), out x1))
{
    Console.WriteLine("Вы ввели не число");
    Console.Write("X1 = ");
}
Console.Write("Y1 = ");
while (!int.TryParse(Console.ReadLine(), out y1))
{
    Console.WriteLine("Вы ввели не число");
    Console.Write("Y1 = ");
}
Console.Write("Z1 = ");
while (!int.TryParse(Console.ReadLine(), out z1))
{
    Console.WriteLine("Вы ввели не число");
    Console.Write("Z1 = ");
}
Console.WriteLine("Введите координаты второй точки");
Console.Write("X2 = ");
while (!int.TryParse(Console.ReadLine(), out x2))
{
    Console.WriteLine("Вы ввели не число");
    Console.Write("X2 = ");
}
Console.Write("Y2 = ");
while (!int.TryParse(Console.ReadLine(), out y2))
{
    Console.WriteLine("Вы ввели не число");
    Console.Write("Y2 = ");
}
Console.Write("Z2 = ");
while (!int.TryParse(Console.ReadLine(), out z2))
{
    Console.WriteLine("Вы ввели не число");
    Console.Write("Z2 = ");
}
double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
Console.WriteLine($"Расстояние между двумя точками равно {result}");
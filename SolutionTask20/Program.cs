

//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D пространстве.


Console.WriteLine("Введите координаты Х точки А");
int coordXALine = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки А");
int coordYALine = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Х точки B");
int coordXBLine = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки B");
int coordYBLine = int.Parse(Console.ReadLine());

//Находим расстояние согласно формуле
double lenghtAB = Math.Sqrt( Math.Pow((coordXALine-coordXBLine),2)+Math.Pow((coordYALine-coordYBLine),2));
Console.WriteLine(lenghtAB);

﻿

//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.


Console.WriteLine("Введите координаты Х точки А");
int coordXALine = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки А");
int coordYALine = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Z точки А");
int coordZALine = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Х точки B");
int coordXBLine = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки B");
int coordYBLine = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Z точки B");
int coordZBLine = int.Parse(Console.ReadLine());

//Находим расстояние согласно формуле
double lenghtAB = Math.Sqrt( Math.Pow((coordXALine-coordXBLine),2)+Math.Pow((coordYALine-coordYBLine),2)+Math.Pow((coordZALine-coordZBLine),2));
Console.WriteLine(lenghtAB);
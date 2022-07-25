

//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D пространстве.


int coordXALine;
int coordXBLine;
int coordYALine;
int coordYBLine;
double lenghtAB;

//метод считывания координат точек
void readDataOfPoint()
{
    Console.WriteLine("Введите координаты Х точки А");
    coordXALine = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты Y точки А");
    coordYALine = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты Х точки B");
    coordXBLine = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты Y точки B");
    coordYBLine = int.Parse(Console.ReadLine());
}

//Метод нахождения расстояния между точками
void distanceAB()
{
    lenghtAB = Math.Sqrt(Math.Pow((coordXALine - coordXBLine), 2) + Math.Pow((coordYALine - coordYBLine), 2));
}

readDataOfPoint();
distanceAB();

Console.WriteLine(lenghtAB);

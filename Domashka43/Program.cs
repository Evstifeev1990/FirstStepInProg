double b1;
double k1;
double b2;
double k2;
double x;
double y;

//метод считывания координат точек
void Read()
{
    Console.WriteLine("Введите первую координату первой линии");
    b1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите вторую координату первой линии");
    k1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите первую координату второй линии");
    b2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите вторую координату второй линии");
    k2 = double.Parse(Console.ReadLine());
}

//расчет точки пересечения двух линий
void Conculate()
{
    x = (b1-b2)/(k1-k2);
    y = k1*((b2-b1)/(k1-k2))+b1;
}

//вывод x, y точки пересечения
void Print()
{
    Console.WriteLine("Точка x = "+x+"Точка y = "+y);
}

Read();
Conculate();
Print();
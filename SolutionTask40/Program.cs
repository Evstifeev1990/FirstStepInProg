int sideA = 0;
int sideB = 0;
int sideC = 0;

ReadSides();
bool res = TestTriangle(sideA,sideB,sideC);
PrintAnswer(res);

void ReadSides()
{
    Console.Write("Введите первое число");
    sideA = int.Parse(Console.ReadLine()??"");
    Console.Write("Введите второе число");
    sideB = int.Parse(Console.ReadLine()??"");
    Console.Write("Введите третье число");
    sideC = int.Parse(Console.ReadLine()??"");
}

bool TestTriangle(int num1, int num2, int num3)
{
    bool answer = ((num1+num2>num3)
    &&(num1+num3>num2)
    &&(num2+num3>num1))? true : false;
    return answer; 
}

void PrintAnswer(bool answer)
{
    if (answer)
    {
        Console.Write("Из этих отрезков можно составить треугольник");
    }
    else
    {
        Console.Write("Из этих отрезков нельзя составить треугольник");
    }
    
}


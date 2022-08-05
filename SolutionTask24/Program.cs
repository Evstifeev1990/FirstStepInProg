Console.Write("Введите число: ");

int imputNamber = int.Parse(Console.ReadLine());
int t;

void VariantSimple()
{
    int sumOfNumbers = 0;

    for (int i = 1; i <= imputNamber; i++)
    {
        sumOfNumbers += i;
    }
    Console.WriteLine("Сумма чисел от 1 до " + imputNamber + " = " + sumOfNumbers);
}

void VariantGauss()
{
    int sumOfNumbers = 0;

    sumOfNumbers = ((1 + imputNamber) * imputNamber) / 2;

    Console.WriteLine("Сумма чисел от 1 до " + imputNamber + " = " + sumOfNumbers);
}

t = Environment.TickCount;
VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);
VariantGauss();
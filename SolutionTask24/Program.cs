Console.Write("Введите число: ");

int imputNamber = int.Parse(Console.ReadLine());

void VariantSimple()
{
    int sumOfNumbers = 0;

    for(int i = 1; i <= imputNamber; i++)
    {
        sumOfNumbers += i;
    }
Console.WriteLine("Сумма чисел от 1 до "+ imputNamber + " = "+ sumOfNumbers);
}
VariantSimple();


Console.Write("Введите нижнюю границу ");
string? inputLine1 = Console.ReadLine()??"";
int imputNamber1 = int.Parse(inputLine1);

Console.Write("Введите верхнюю границу ");
string? inputLine2 = Console.ReadLine()??"";
int imputNamber2 = int.Parse(inputLine2);  

Console.Write("Введите длинну массива ");
string? inputLine3 = Console.ReadLine()??"";
int imputNamber3 = int.Parse(inputLine3); 


System.Random numberSintezator = new Random();

void VariantNaive()
{
    int i = 0;
    Console.Write("[");
    while (i < imputNamber3 - 1)
    {
        Console.Write(numberSintezator.Next(imputNamber1, imputNamber2+1) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(imputNamber1, imputNamber2+1));
    Console.Write("]");
}

VariantNaive();
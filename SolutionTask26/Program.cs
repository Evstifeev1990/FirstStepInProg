Console.Write("Введите число: ");

string inputLineNamber = Console.ReadLine() ?? "";
int imputNamber = int.Parse(inputLineNamber);

DateTime timePoint = DateTime.Now;

int VariantChar()
{
    // int namberLength = 0;
    // char[] array = inputLineNamber.ToCharArray();
    // namberLength = array.Length;

    return inputLineNamber.ToCharArray().Length;
}

int VariantSimple()
{
    int namberLength = 0;
    int digits = 1;
    while(digits <= imputNamber)
    {
        digits = digits*10;
        namberLength++;
    }
    return namberLength;
}

int VariantLog10()
{
    return (int)Math.Log10(imputNamber)+1;
}

int result = 0;

timePoint = DateTime.Now;
result = VariantChar();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantSimple();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantLog10();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);


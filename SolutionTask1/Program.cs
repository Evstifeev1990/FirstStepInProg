string? InputLine1 = Console.ReadLine();
string? InputLine2 = Console.ReadLine();

if (InputLine1 != null && InputLine2 != null)
{
    int inputNamber1 = int.Parse(InputLine1);
    int inputNamber2 = int.Parse(InputLine2);

    if (inputNamber1 == Math.Pow(inputNamber2, 2))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
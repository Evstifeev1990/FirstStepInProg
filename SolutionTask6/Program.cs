string? InputLine1 = Console.ReadLine();
string? InputLine2 = Console.ReadLine();
string? InputLine3 = Console.ReadLine();

if (InputLine1 != null && InputLine2 != null && InputLine3 != null)
{
    int inputNamber1 = int.Parse(InputLine1);
    int inputNamber2 = int.Parse(InputLine2);
    int inputNamber3 = int.Parse(InputLine3);

    if(Math.Max(inputNamber1, inputNamber2) > inputNamber3)
    {
        Console.WriteLine("Максимальное = " + Math.Max(inputNamber1, inputNamber2));
    
    }
    else
    {
        Console.WriteLine("Максимальное = " + inputNamber3);
    }
}


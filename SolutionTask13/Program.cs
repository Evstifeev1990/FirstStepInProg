string? InputLine1 = Console.ReadLine();
string? InputLine2 = Console.ReadLine();

if (InputLine1 != null && InputLine2 != null)
{
    int inputNamber1 = int.Parse(InputLine1);
    int inputNamber2 = int.Parse(InputLine2);
    // int inputNamber3 = inputNamber1%inputNamber2;

    if (inputNamber2 == Math.Pow(inputNamber1, 2))
    {
        Console.WriteLine("Да");
    }
    else
    {
        if (inputNamber1 == Math.Pow(inputNamber2, 2))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");  
        }
    }
    
    
    
    
    

}

    

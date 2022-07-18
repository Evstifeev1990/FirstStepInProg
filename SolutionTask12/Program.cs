string? InputLine1 = Console.ReadLine();

if (InputLine1 != null)
{
    int inputNamber1 = int.Parse(InputLine1);


    if(inputNamber1%23 == 0 && inputNamber1%7 == 0)
    {
        Console.WriteLine("Кратно");
    }
    
    else
    {
        Console.WriteLine("Нет");
    }
        
}


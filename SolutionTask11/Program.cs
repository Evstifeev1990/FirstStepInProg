string? InputLine1 = Console.ReadLine();
string? InputLine2 = Console.ReadLine();

if (InputLine1 != null && InputLine2 != null)
{
    int inputNamber1 = int.Parse(InputLine1);
    int inputNamber2 = int.Parse(InputLine2);
    int inputNamber3 = inputNamber1%inputNamber2;

    if(inputNamber1%inputNamber2 == 0)
    {
        Console.WriteLine("Кратно");
    }
    
    else
    {
        Console.WriteLine(inputNamber3);
    }
    
        
    
    
}

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNamber = int.Parse(inputLine);

    if(inputNamber%2 == 0)
    {
       Console.WriteLine("Число чётное"); 
    }
    else
    {
       Console.WriteLine("Число нечётное");
    }
    
}

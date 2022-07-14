string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNamber = int.Parse(inputLine);

    int zeroNamber = 2;

    string outputLine = "";

    while(zeroNamber < inputNamber)
    {
        if(zeroNamber%2 == 0)
        {
            outputLine = outputLine + zeroNamber + ", ";
        }

        zeroNamber++;
    }

    if(zeroNamber%2 == 0)
    {
        outputLine = outputLine + zeroNamber;
    }


    Console.Write(outputLine);

}   
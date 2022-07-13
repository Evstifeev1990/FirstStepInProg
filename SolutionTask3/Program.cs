string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNamber = int.Parse(inputLine);

    int minusNamber = 1;

    string outputLine = "0";

    while(minusNamber <= inputNamber)
    {
        outputLine = minusNamber*-1 + ", " + outputLine + ", " + minusNamber;

        minusNamber++;
    }

    // outputLine = outputLine + inputNamber;

    Console.Write(outputLine);

}   
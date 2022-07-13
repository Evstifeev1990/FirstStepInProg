string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNamber = int.Parse(inputLine);

    int minusNamber = inputNamber * -1;

    string outputLine = "";

    while(minusNamber < inputNamber)
    {
        outputLine = outputLine + minusNamber + ", ";

        minusNamber++;
    }

    outputLine = outputLine + inputNamber;

    Console.Write(outputLine);

}   
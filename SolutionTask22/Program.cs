string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int namberN = int.Parse(inputLine);

    string lineNone = string.Empty;

    string lineNtwo = string.Empty;

    int s = 0;

    while(s <= namberN)
    {
        lineNone = lineNone + s + " ";

        lineNtwo = lineNtwo + Math.Pow(s, 2) + " ";

        s++;
    }

    // outputLine = outputLine + inputNamber;

    Console.WriteLine(lineNone);
    Console.WriteLine(lineNtwo);

}   

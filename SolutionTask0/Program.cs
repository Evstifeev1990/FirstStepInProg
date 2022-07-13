string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNamber = int.Parse(inputLine);

    //int outNamber = inputNamber * inputNamber;
    int outNamber = (int)Math.Pow(inputNamber, 2);

    Console.WriteLine(outNamber);
}
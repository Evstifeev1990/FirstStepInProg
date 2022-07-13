string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNamber = int.Parse(inputLine);

    int threeNamber = inputNamber%10;

    Console.WriteLine(threeNamber);

}

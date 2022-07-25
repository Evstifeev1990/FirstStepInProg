void printAnswer(int namber)
{
    if(namber == 1) Console.WriteLine("Допустимо: x>0, y>0");
    if(namber == 2) Console.WriteLine("Допустимо: x<0, y>0");
    if(namber == 3) Console.WriteLine("Допустимо: x<0, y<0");
    if(namber == 4) Console.WriteLine("Допустимо: x>0, y<0");

}

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNamber = int.Parse(inputLine);

    printAnswer(inputNamber);

}
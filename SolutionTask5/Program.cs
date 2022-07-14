string? InputLine1 = Console.ReadLine();
string? InputLine2 = Console.ReadLine();

if (InputLine1 != null && InputLine2 != null)
{
    int inputNamber1 = int.Parse(InputLine1);
    int inputNamber2 = int.Parse(InputLine2);

    if (inputNamber1 > inputNamber2)
    {
        Console.WriteLine("Первое число больше второго");
    }
    if (inputNamber1 < inputNamber2)
    {
        Console.WriteLine("Второе число больше первого");
    }
    if (inputNamber1 == inputNamber2)
    {
        Console.WriteLine("Оба числа равны");
    }
    

}

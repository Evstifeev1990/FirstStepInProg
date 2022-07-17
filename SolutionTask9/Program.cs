System.Random numberSintezator = new Random();

//метод решения задачи вариянт1
void variant1(System.Random numberSintezator)
{
    int index = numberSintezator.Next(10, 100);

    int oneNamber = index / 10;

    int twoNamber = index % 10;

    Console.WriteLine(index);

    if (oneNamber > twoNamber)
    {
        Console.WriteLine(oneNamber);
    }
    else
    {
        Console.WriteLine(twoNamber);
    }
}

variant1(numberSintezator);


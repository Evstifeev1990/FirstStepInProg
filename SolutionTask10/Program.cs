System.Random numberSintezator = new Random();

void noldva(System.Random numberSintezator)
{
    int index = numberSintezator.Next(100, 1000);

    Console.WriteLine(index);

    string stroka = index.ToString();


    Console.Write(stroka[0]);
    Console.Write(stroka[2]);
}

noldva(numberSintezator);

// int oneNamber = index / 10;

// int twoNamber = index % 10;

// Console.WriteLine(index);

// if (oneNamber > twoNamber)
// {
//     Console.WriteLine(oneNamber);
// }
// else
// {
//     Console.WriteLine(twoNamber);
// }
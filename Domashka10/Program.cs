System.Random numberSintezator = new Random();

//метод решения задачи вариянт1
void variant1(System.Random numberSintezator)
{
    int index = numberSintezator.Next(100, 1000);

    Console.WriteLine(index);

    int oneNamber = index / 10;

    int twoNamber = oneNamber % 10;

    Console.WriteLine(twoNamber);

}

variant1(numberSintezator);


//метод решения задачи вариянт2
void variant2(System.Random numberSintezator)
{
    int index = numberSintezator.Next(100, 1000);

    Console.WriteLine(index);

    string stroka = index.ToString();

    Console.Write(stroka[1]);
}

variant2(numberSintezator);

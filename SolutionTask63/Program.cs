

int ReadData()
{
    Console.WriteLine("Введите число: ");
    return int.Parse(Console.ReadLine());
}

int NuturalNamber(int nam)
{
    if(nam == 2)return 1;
    else
    {
        nam--;
        Console.Write(NuturalNamber(nam));
    }
    return nam;
}

NuturalNamber(3);
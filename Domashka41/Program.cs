//объявляем переменную длины массива m
Console.WriteLine("Введите длину массива");
//переводим стринг в инт
int m = int.Parse(Console.ReadLine());

//метод заполнения массива длины m рандомными числами
int[] Read(int m)
{
    int[] nam = new int[m];
    int i = 0;
    while(i<m)
    {
        nam[i] = new System.Random().Next(-100,100);
        i++;
    }
    return nam;
}

//метод подсчёта элементов массива больше 0
int Colculate (int[] nam)
{
    int colichestvo = 0;
    int i = 0;
    while(i<nam.Length)
    {
        if (nam[i]>0) colichestvo++;
        i++;
    }
    return colichestvo;
}

//медот вывода массива на экран
void PrintInArray(int[] inputArray)
{
    int i =0;
    int n = inputArray.Length;
    while(i<(n-1))
    {
        Console.Write(inputArray[i]+", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

int[] newArray = Read(m);
PrintInArray(newArray);
int amount = Colculate(newArray);
Console.WriteLine("Число положительных чисел = "+amount);


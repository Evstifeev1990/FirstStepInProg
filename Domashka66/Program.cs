
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

int namberM = ReadData("Задайте число М");
int namberN = ReadData("Задайте число N");

int sum = 0;

void SumNaturalNamber(int m, int n)
{
    if (m - 1 == n)  
    {
        Console.WriteLine("Сумма всех элементов = "+sum);
        return;
    }
    sum = sum+m;
    SumNaturalNamber(m + 1, n);
}

if (namberM < namberN) SumNaturalNamber(namberM, namberN);
else SumNaturalNamber(namberN, namberM);

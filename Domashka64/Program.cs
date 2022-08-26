
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

int namberM = ReadData("Задайте число М");
int namberN = ReadData("Задайте число N");

void NaturalNamber(int m, int n)
{
    if (m - 1 == n) return;
    Console.Write(m + " ");
    NaturalNamber(m + 1, n);
}

if (namberM < namberN) NaturalNamber(namberM, namberN);
else NaturalNamber(namberN, namberM);

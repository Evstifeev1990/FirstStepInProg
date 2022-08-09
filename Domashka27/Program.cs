
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine() ?? "";
int inputNum = int.Parse(inputLine);
DateTime timePoint = DateTime.Now;

//подскажите как решить методом перевода в массив???
void MetodNaiv()
{
    int sum = 0;
    while (inputNum>0)
    {
        sum = sum + inputNum%10;
        inputNum = inputNum/10;
    }
    Console.WriteLine("Сумма чисел данного числа = "+sum);

}

timePoint = DateTime.Now;
MetodNaiv();
Console.WriteLine(DateTime.Now - timePoint);
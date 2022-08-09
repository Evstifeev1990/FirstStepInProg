Console.WriteLine("Введите два числа");


string? inputLine1 = Console.ReadLine()??"";
string? inputLine2 = Console.ReadLine()??"";

int imputNamber1 = int.Parse(inputLine1);
int imputNamber2 = int.Parse(inputLine2);  


void MetodNaiv1()
{
    int degree = 0;
    degree = (int)Math.Pow(imputNamber1, imputNamber2);
    Console.WriteLine("Первое число в степени второго = "+degree);
}

void MetodNaiv2()
{
    int i =1;
    int num = imputNamber1;
    int degree1 = 1;

    while(i<=imputNamber2)
    {
        degree1 = degree1*num;
        i++;
    }
    Console.WriteLine("Первое число в степени второго = "+degree1);
}


MetodNaiv1();
MetodNaiv2();



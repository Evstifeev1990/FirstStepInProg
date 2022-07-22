string? InputLine1 = Console.ReadLine();

if (InputLine1 != null)
{
    //метод определяющий палиндром
    void Palindrom(string InputLine1)
    {
        int inputNamber1 = int.Parse(InputLine1);
        //присваеваем каждую цыфру пятизначного числа переменной
        int firstDigit = inputNamber1 / 10000;
        int secondDigit = (inputNamber1 % 10000) / 1000;
        int thirdDigit = (inputNamber1 % 1000) / 100;
        int fourthDigit = (inputNamber1 % 100) / 10;
        int fifthDigit = inputNamber1 % 10;

        //проверяем условие палиндрома
        if (firstDigit == fifthDigit && secondDigit == fourthDigit)
        {
            Console.WriteLine("число является палиндромом");
        }
        else
        {
            Console.WriteLine("число не является палиндромом");
        }
    }
    Palindrom(InputLine1);
    
}




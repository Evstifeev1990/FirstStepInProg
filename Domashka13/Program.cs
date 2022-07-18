string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    // первый вариант
    void Tri(string vvod)
    {
        int inputNamber = int.Parse(vvod);

        if (inputNamber > 99)
        {
            // Переводим число в строку
            string stroka = inputNamber.ToString();
            Console.WriteLine(stroka[2]);
        }
        else
        {
            Console.WriteLine("Третьего числа нет");
        }


    }

    
    // второй вариант
    void Tri2(string vvod1)
    {
        try
        {
            Console.Write(vvod1[2]);
        }
        // ловим ошибку
        catch
        {
            Console.WriteLine("Третьего числа нет");
        }
    }

    Tri(inputLine);
    Tri2(inputLine);
}

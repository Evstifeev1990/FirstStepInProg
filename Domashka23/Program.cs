//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int namberN = int.Parse(inputLine);

    string lineNcub = string.Empty;

    int s = 1;

    //цикл нахождения кубов чисел от 1 до введённого числа
    while(s <= namberN)
    {
        lineNcub = lineNcub + Math.Pow(s, 3) + " ";

        s++;
    }

    

  // вывод результата
    Console.WriteLine(lineNcub);

}   

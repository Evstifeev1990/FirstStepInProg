string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    // вариант первый
    void vykhodnoy(string den)
    {
       int inputDen = int.Parse(den);

       if (inputDen == 6 || inputDen == 7)
       {
            Console.WriteLine("Да");
       } 
       else
       {
            Console.WriteLine("Нет");
       }
    }
    
    vykhodnoy(inputLine);
    
     void vykhodnoy1(string den)
    {
       int inputDen = int.Parse(den);

       if (inputDen / 6 == 1 || inputDen / 7 == 1)
       {
            Console.WriteLine("Да");
       } 
       else
       {
            Console.WriteLine("Нет");
       }
    }

    vykhodnoy1(inputLine);
}

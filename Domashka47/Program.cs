//медот заполнения двумерного массива вещественными числами
double[,] FillTwoDimArray(int countRow, int countColum)
{
    
    System.Random namberSintezator = new System.Random();
    int i = 0; int j = 0;

    double[,] outArray = new double[countRow, countColum];
    
    while(i<countRow)
    {
        j = 0;
        while(j<countColum)
        {
            //вещественные числа от -10 до 9.9
            outArray[i,j] = Convert.ToDouble(namberSintezator.Next(-100,100)/10.0);
            j++;
        }
        i++;
    }
    return outArray;
}
//массив цветов 5 штук )))))
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Red, ConsoleColor.Green};

//медот вывода двумерного массива на экран
void PrintInTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;
    
    while(i<inputArray.GetLength(0))
    {
        j = 0;
        while(j<inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 5)];
            Console.Write(inputArray[i,j]+ " ");
            Console.ResetColor();
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

double[,] twoDimArray = FillTwoDimArray(5,8);
PrintInTwoDimArray(twoDimArray);
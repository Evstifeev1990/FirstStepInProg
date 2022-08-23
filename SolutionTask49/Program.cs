//медот заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColum)
{
    
    System.Random namberSintezator = new System.Random();
    int i = 0; int j = 0;

    int[,] outArray = new int[countRow, countColum];
    
    while(i<countRow)
    {
        j = 0;
        while(j<countColum)
        {
            outArray[i,j] = namberSintezator.Next(0,10);
            j++;
        }
        // Console.WriteLine();
        i++;
    }
    return outArray;
}

//медот вывода двумерного массива на экран
void PrintInTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    
    while(i<inputArray.GetLength(0))
    {
        j = 0;
        while(j<inputArray.GetLength(1))
        {
            Console.Write(inputArray[i,j]+ " ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}


//медот вывода двумерного массива на экран
void PrintSquareArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    
    while(i<inputArray.GetLength(0))
    {
        j = 0;
        while(j<inputArray.GetLength(1))
        {
            if (i%2==0 && j%2==0)
            {
                Console.Write(Math.Pow(inputArray[i,j], 2)+ " ");
            }
            else
            {
                Console.Write(inputArray[i,j]+ " ");
            }
            j++;
        }
        Console.WriteLine();
        i++;
    }
}
    
int[,] twoDimArray = FillTwoDimArray(5,8);
PrintInTwoDimArray(twoDimArray);
Console.WriteLine();
PrintSquareArray(twoDimArray);


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
        i++;
    }
    return outArray;
}


//медот вывода двумерного массива на экран
void PrintInArray(int[,] inputArray)
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

//медот вывода суммы чисел столбцов массива на экран
void PrintSumArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    int sum;

    //прогоняем столбцы 
    while(j<inputArray.GetLength(1))
    {
        i = 0;
        //перед каждым циклом обнуляем сумму
        sum =0;
        //прогоняем строки в столбце
        while(i<inputArray.GetLength(0))
        {
            sum = sum + inputArray[i,j];
            i++;
        }
        Console.Write(sum+"; ");
        j++;
    }
}
    

int[,] twoDimArray = FillTwoDimArray(5,8);
PrintInArray(twoDimArray);
Console.WriteLine();
PrintSumArray(twoDimArray);

﻿//медот заполнения двумерного массива
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
            outArray[i,j] = namberSintezator.Next(0,100);
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

void PrintSumArray(int[,] inputArray)
{
    int i = 0; int j = 0; int sum = 0;
    
    while(i<inputArray.GetLength(0))
    {
        j = 0;
        while(j<inputArray.GetLength(1))
        {
            if (i==j)
            {
                sum = sum + inputArray[i,j];
            }
            j++;
        }
        i++;
    }
    Console.WriteLine("Сумма элементов диагонали = "+sum);
}


int[,] twoDimArray = FillTwoDimArray(5,8);
PrintInTwoDimArray(twoDimArray);
Console.WriteLine();
PrintSumArray(twoDimArray);

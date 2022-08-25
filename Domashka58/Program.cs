//медот заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColum)
{

    System.Random namberSintezator = new System.Random();
    int i = 0; int j = 0;

    int[,] outArray = new int[countRow, countColum];

    while (i < countRow)
    {
        j = 0;
        while (j < countColum)
        {
            outArray[i, j] = namberSintezator.Next(0, 10);
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

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

int[,] ProizvedenieArray(int[,] inputA, int[,] inputB)
{
    int i = 0; int j = 0; int[,] array = new int[inputA.GetLength(0),inputA.GetLength(1)];

    while (i < inputA.GetLength(0))
    {
        j = 0;
        while (j < inputA.GetLength(1))
        {
            array[i,j] = inputA[i,j]*inputB[i,j];
            j++;
        }
        i++;
    }
    return array;
}

int[,] twoDimArray1 = FillTwoDimArray(4, 4);
int[,] twoDimArray2 = FillTwoDimArray(4, 4);
PrintInTwoDimArray(twoDimArray1);
Console.WriteLine();
PrintInTwoDimArray(twoDimArray2);
Console.WriteLine();
PrintInTwoDimArray(ProizvedenieArray(twoDimArray1, twoDimArray2));


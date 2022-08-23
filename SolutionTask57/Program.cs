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

//медот вывода массива на экран
void PrintInArray(int[] inputArray)
{
    int i = 0;
    int n = inputArray.Length;
    while (i < (n - 1))
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

int[] FreqmancyCollect(int[,] inputArray, int lengthArray)
{
    int[] resaltArray = new int[lengthArray];
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            //собираем частоту появления элемента
            resaltArray[inputArray[i,j]]++;
            j++;
        }
        i++;
    }
    return resaltArray;
}
int[,] twoDimArray = FillTwoDimArray(5, 5);
PrintInTwoDimArray(twoDimArray);
Console.WriteLine();
PrintInArray(FreqmancyCollect(twoDimArray, 10));





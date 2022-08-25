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

void FiltrArray(int[,] input)
{
    int i = 0; int j = 0; int sum = 0; int sum1 =int.MaxValue; int c = 0;

    while (i < input.GetLength(0))
    {
        j = 0; sum =0;
        while (j < input.GetLength(1))
        {
            sum = sum + input[i,j];
            j++;
        }
        if (sum<sum1)
        {
            sum1 = sum;
            c = i;
        }
        i++;
    }
    Console.WriteLine("Наименьшая сумма элементов - "+c+" строчка");
}

int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintInTwoDimArray(twoDimArray);
Console.WriteLine();
FiltrArray(twoDimArray);

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
            outArray[i, j] = namberSintezator.Next(0, 100);
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

int[,] FiltrArray(int[,] input)
{
    int i = 0; int j = 0; int c = 0;

    while (i < input.GetLength(0))
    {
        j = 0; 
        while (j < input.GetLength(1))
        {
            c = 0;
            while ( c < input.GetLength(1)-1)
            {
                if (input[i, c] > input[i, c + 1])
                {
                    int z = input[i, c];
                    input[i, c] = input[i, c + 1];
                    input[i, c + 1] = z;
                }
                c++;
            }
            j++;
        }
        i++;
    }
    return input;
}

int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintInTwoDimArray(twoDimArray);
Console.WriteLine();
PrintInTwoDimArray(FiltrArray(twoDimArray));
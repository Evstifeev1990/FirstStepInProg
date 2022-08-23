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

int[,] FirstLast(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = i;
        while (j < inputArray.GetLength(1))
        {
            bufferElement = inputArray[i, j];
            inputArray[i, j] = inputArray[j, i];
            inputArray[j, i] = bufferElement;
            j++;
        }
        i++;
    }
    return inputArray;
}

void ProverkaArray(int[,] inputArray)
{

    if (inputArray.GetLength(0) != inputArray.GetLength(1))
    {
        Console.WriteLine("Данное условие невозможно!!!");
    }
    else
    {
        PrintInTwoDimArray(FirstLast(inputArray));
    }
       
}


int[,] twoDimArray = FillTwoDimArray(5,5);
PrintInTwoDimArray(twoDimArray);
Console.WriteLine();
ProverkaArray(twoDimArray);




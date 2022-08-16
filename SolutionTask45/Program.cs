int[] CopyArrayStandartTool(int[] inputArray)
{
    int[] buferArray = new int[inputArray.Length];
    inputArray.CopyTo(buferArray, 0);
    return inputArray;
}

//медот заполнения массива
int[] FillingArray()
{
    int[] outArray = new int[123];
    int i = 0;
    System.Random namberSintezator = new System.Random();
    while(i<123)
    {
        outArray[i] = namberSintezator.Next(-1000,1000);
        i++;
    }
    return outArray;
}

//медот вывода массива на экран
void PrintInArray(int[] inputArray)
{
    int i =0;
    int n = inputArray.Length;
    while(i<(n-1))
    {
        Console.Write(inputArray[i]+", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

int[] testArray = FillingArray();
PrintInArray(testArray);

int[] outArray = CopyArrayStandartTool(testArray);
PrintInArray(outArray);
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

//метод
int[] ColculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length/2+1];
    int i = 0;
    while(i<resultArray.Length)
    {
        resultArray[i] = inputArray[i]*inputArray[inputArray.Length-1-i];
        i++;
    }
    return resultArray;
}

int[] bufferArray = FillingArray();
PrintInArray(bufferArray);
int[] resultArray = ColculateTask(bufferArray);
PrintInArray(resultArray);
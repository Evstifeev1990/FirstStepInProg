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

//метод нахождения числа
int ColculateTask(int[] inputArray, int downBorder, int upBorder)
{
    int resultCount = 0;
    int i = 0;
    while(i<inputArray.Length)
    {
        if(inputArray[i] >= downBorder && inputArray[i]<=upBorder) 
        {
            resultCount++;
        }
        i++;
    }
    return resultCount;
}

int[] bufferArray = FillingArray();
PrintInArray(bufferArray);
Console.WriteLine(ColculateTask(bufferArray, 19,99 ));

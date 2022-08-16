//медот заполнения массива
int[] FillingArray(int arrayLenght)
{
    int[] outArray = new int[arrayLenght];
    int i = 0;
    System.Random namberSintezator = new System.Random();
    while(i<arrayLenght)
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

// метод переворачивания одномерного массива
int[] ReversNewArray(int[] inputArray)
{
    int length = inputArray.Length;
    int[] newArray = new int[length];

    for(int i = 0; i<length; i++)
    {
        newArray[length-1-i] = inputArray[i];
    }
    return newArray;
}

int[] ReversSwapArray(int[] inputArray)
{
    int length = inputArray.Length;
    int buf;

    for(int i = 0; i<length/2; i++)
    {
        buf = inputArray[i];
        inputArray[i] = inputArray[length-1-i];
        inputArray[length-1-i] = buf;
    }
    return inputArray;
}

int[] testArray = FillingArray(13);
PrintInArray(testArray);
int[] reversArray = ReversNewArray(testArray);
PrintInArray(reversArray);
int[] reversSwapArray = ReversSwapArray(testArray);
PrintInArray(reversSwapArray);

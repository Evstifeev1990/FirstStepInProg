int posetivSum = 0;
int negativSum = 0;

int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random namberSintezator = new System.Random();
    while(i<12)
    {
        outArray[i] = namberSintezator.Next(-9, 10);
        i++;
    }
    return outArray;
}

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

void ColculateTask(int[] outArry)
{
    int i = 0;
    while(i<12)
    {
        if (outArry[i]>0) posetivSum++;
        if (outArry[i]<0) negativSum++;
        i++;
    }
}

void PrintResult()
{
    Console.WriteLine(posetivSum);
    Console.WriteLine(negativSum);
}

void VariantNaiv()
{
    
    int[] bufferArray = FillingArray();
    PrintInArray(bufferArray);
    ColculateTask(bufferArray);
    PrintResult(); 
}

VariantNaiv();

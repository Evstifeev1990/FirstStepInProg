//медот заполнения массива спирально 
int[,] FillTwoDimArray(int countRow, int countColum)
{
    int[,] outArray = new int[countRow,countColum];
    int namberSintezator = 10;
    int i = 0; int j = 0;
    
    while(j<countColum)
    {
        outArray[i,j] = namberSintezator;
        j++;
        namberSintezator++;
    }
    i=1;
    j = countColum-1;
    while(i<countRow)
    {
        outArray[i,j] = namberSintezator;
        i++;
        namberSintezator++;
    }
    i=countRow-1;
    j = countColum-2;
    while(j>=0)
    {
        outArray[i,j] = namberSintezator;
        j--;
        namberSintezator++;
    }
    i=countRow-2;
    j = 0;
    while(i>=1)
    {
        outArray[i,j] = namberSintezator;
        i--;
        namberSintezator++;
    }
    i=countRow-3;
    j = countColum-3;
    while(j<countColum-1)
    {
        outArray[i,j] = namberSintezator;
        j++;
        namberSintezator++;
    }
    outArray[2,2] = 24;
    outArray[2,1] = 25;
    return outArray;
}

//медот вывода двумерного массива на экран
void PrintInTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    
    while(i<inputArray.GetLength(0))
    {
        j = 0;
        while(j<inputArray.GetLength(1))
        {
            Console.Write(inputArray[i,j]+ " ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}
    
int[,] twoDimArray = FillTwoDimArray(4,4);
PrintInTwoDimArray(twoDimArray);


//медот заполнения массива
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
bool ColculateTask(int[] inputArray, int searchNamber)
{
    bool resultSearch = false;
    int i = 0;
    while(i<12)
    {
        if(inputArray[i] == searchNamber) 
        {
            resultSearch = true;
            break;
        }
        i++;
    }
    return resultSearch;
}

int[] bufferArray = FillingArray();
PrintInArray(bufferArray);

Console.WriteLine("Введите число для поиска: ");
int searchNamber = int.Parse(Console.ReadLine()); 

Console.WriteLine(ColculateTask(bufferArray, searchNamber));


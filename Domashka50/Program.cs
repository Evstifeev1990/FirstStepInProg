//медот заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColum)
{
    
    System.Random namberSintezator = new System.Random();
    int i = 0; int j = 0;

    int[,] outArray = new int[countRow, countColum];
    
    while(i<countRow)
    {
        j = 0;
        while(j<countColum)
        {
            outArray[i,j] = namberSintezator.Next(0,100);
            j++;
        }
        i++;
    }
    return outArray;
}

//Метод считывания введённых данных

int [] InputPosition()
{
    int[] array = new int[2];

    Console.WriteLine("Введите первую позицию");
    string inputLineNamber1 = Console.ReadLine() ?? "";
    int imputNamber1 = int.Parse(inputLineNamber1);
    array[0] = imputNamber1;

    Console.WriteLine("Введите вторую позицию");
    string inputLineNamber2 = Console.ReadLine() ?? "";
    int imputNamber2 = int.Parse(inputLineNamber2);
    array[1] = imputNamber2;
    
    return array;   
}

//медот вывода числа введённой позиции
void PrintInTwoDimArray(int[,] inputArray, int[] array)
{
    int i = 0; int j = 0;

    string element = string.Empty;
    
    while(i<inputArray.GetLength(0))
    {
        j = 0;
        while(j<inputArray.GetLength(1))
        {
            if (i == array[0] && j == array[1])
            {
                element = inputArray[i,j].ToString();
                Console.WriteLine(element);
                return;
            }    
            j++;
        }
        i++;
    }
    if (element == string.Empty)
    {
        Console.WriteLine("Такого элемента нет");
    }

    
}

//медот вывода двумерного массива на экран
void PrintInArray(int[,] inputArray)
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
    

int[] array1 = InputPosition();
int[,] twoDimArray = FillTwoDimArray(5,8);
Console.WriteLine();
PrintInArray(twoDimArray);
Console.WriteLine();
PrintInTwoDimArray(twoDimArray, array1);

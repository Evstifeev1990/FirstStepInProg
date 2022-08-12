//медот заполнения массива
int[] FillingArray()
{
    //указываем длинну массива
    int[] outArray = new int[15];
    int i = 0;
    //вводим рандомную переменную
    System.Random namberSintezator = new System.Random();
    //цикл длины массива
    while(i<15)
    {
        //присвоение  числа массиву
        outArray[i] = namberSintezator.Next(10, 100);
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

//метод нахождения суммы минимального и максимального элементов массива
int ColculateTask(int[] inputArray)
{
    
    //кладём в минимальное значение максимальное число
    int min = int.MaxValue;
    //максимому присваеваем ноль
    int max = 0;
    int i = 0;
    //цикл по длине массива
    while(i<15)
    {
        //проверкаи на условие минимума
        if(inputArray[i]<min) 
        {
            min = inputArray[i];    
        }
        //проверкаи на условие максимума
        if(inputArray[i]>max) 
        {
            max = inputArray[i];    
        }
        i++;
    }
    //выводим сумму мин и макс
    return min+max;
}

//формирование массива
int[] bufferArray = FillingArray();
//вывод массива
PrintInArray(bufferArray);
//вывод количества чётных чисел
Console.WriteLine("сумма мин и макс = "+ColculateTask(bufferArray));

//медот заполнения массива
int[] FillingArray()
{
    //указываем длинну массива
    int[] outArray = new int[10];
    int i = 0;
    //вводим рандомную переменную
    System.Random namberSintezator = new System.Random();
    //цикл длины массива
    while(i<10)
    {
        //присвоение трёхзначного числа массиву
        outArray[i] = namberSintezator.Next(100, 1000);
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
int ColculateTask(int[] inputArray)
{
    //ввод переменной количества чётных чисел
    int resultSearch = 0;
    int i = 0;
    //цикл по длине массива
    while(i<10)
    {
        //проверкаи на условие чётности
        if(inputArray[i]%2 == 0) 
        {
            resultSearch++;
        }
        i++;
    }
    return resultSearch;
}

//формирование массива
int[] bufferArray = FillingArray();
//вывод массива
PrintInArray(bufferArray);
//вывод количества чётных чисел
Console.WriteLine("Количество чётных чисел в массиве = "+ColculateTask(bufferArray));
//медот заполнения трёхмерного массива
int[,,] FillTwoDimArray(int countRow, int countColum, int count)
{

    System.Random namberSintezator = new System.Random();
    int i = 0; int j = 0; int c = 0; int d = 0;

    int[,,] outArray = new int[countRow, countColum, count];
    List<int> namber = new List<int>();

    //цикл трёхмерного массива
    while (i < countRow)
    {
        j = 0;
        while (j < countColum)
        {
            c = 0;
            while (c < count)
            {
                d = 0;
                int f = 0;
                //цикл замены повтора
                while (d < 100)
                {
                    f = namberSintezator.Next(10, 100);
                    if (namber.Contains(f))
                    {
                        d++;
                    }
                    else
                    {
                        namber.Add(f);
                        break;
                    }
                }
                outArray[i, j, c] = f;
                c++;
            }
            j++;
        }
        i++;
    }
    return outArray;
}

//медот вывода трёхмерного массива на экран
void PrintInTwoDimArray(int[,,] inputArray)
{
    int i = 0; int j = 0; int c = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            c = 0;
            while (c < inputArray.GetLength(2))
            {
                Console.Write(inputArray[i, j, c] + "(" + i + "," + j + "," + c + ") ");
                c++;
            }
            Console.WriteLine();
            j++;
        }
        i++;
    }
}



int[,,] twoDimArray1 = FillTwoDimArray(3, 3, 3);
PrintInTwoDimArray(twoDimArray1);



//Метод считывает точки и возвращает массив
int[,] readPoint()
{
    string imputLine = Console.ReadLine();

    //x=34; y=-30

    string coordXline = imputLine.Substring(0,imputLine.IndexOf(";"));
    coordXline = coordXline.Substring(coordXline.IndexOf("=")+1);

    string coordYline = imputLine.Substring(imputLine.IndexOf(";")+1);
    coordYline = coordYline.Substring(coordYline.IndexOf("=")+1);

    int coordX = int.Parse(coordXline);
    int coordY = int.Parse(coordYline);

    int[,] arrayout = new int[1,2];
    arrayout[0,0] = coordX;
    arrayout[0,1] = coordX;

    return arrayout;

}

//печатает номер четверти
void printQuarter(int[,] arrayPoint)
{
    if(arrayPoint[0,0]>0 && arrayPoint[0,1]>0)
    Console.WriteLine("Первая четверть");

    if(arrayPoint[0,0]<0 && arrayPoint[0,1]>0)
    Console.WriteLine("Вторая четверть");

    if(arrayPoint[0,0]<0 && arrayPoint[0,1]<0)
    Console.WriteLine("Третья четверть");

    if(arrayPoint[0,0]>0 && arrayPoint[0,1]<0)
    Console.WriteLine("Четвёртая четверть");

}

int[,] arrayPoint = readPoint();

printQuarter(arrayPoint);
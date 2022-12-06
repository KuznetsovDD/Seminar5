// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

var arr =FillArray(5);
Print(arr);
System.Console.WriteLine();
double min = MinNum(arr);
double max = MaxNum(arr);
System.Console.WriteLine($"Max numb {max} - min numb {min} = {max-min}");

double[] FillArray(int lenght)
{
    double[] array = new double[lenght];
    for(int i=0; i < lenght; i++)
    {
        array[i] =new Random().NextDouble();
    }
    return array;
}

void Print(double[]array)
{
    foreach(var item in array)
    {
    Console.Write($"{item} ");
    }
}

double MinNum(double[] arry)
{
    double min= arry[0];
    for(int i=0; i<arry.Length; i++)
    {
        if(min>arry[i])
        {
            min=arry[i];
        }
    }
    return min;
}
double MaxNum(double[] arry)
{
    double max= arry[0];
    for(int i=0; i<arry.Length; i++)
    {
        if(max<arry[i])
        {
            max=arry[i];
        }
    }
    return max;
}
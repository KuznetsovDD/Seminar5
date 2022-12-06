// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

var arr =FillArray(6);
Print(arr);
Console.WriteLine();
var sum= SumNum(arr);
System.Console.WriteLine(sum);

int[] FillArray(int lenght)
{
    int[] array = new int[lenght];
    for(int i=0; i < lenght; i++)
    {
        array[i] =new Random().Next(1, 101);
    }
    return array;
}

void Print(int[]array)
{
    foreach(var item in array)
    {
    Console.Write($"{item} ");
    }
}
int SumNum(int[] array)
{
    int sum = 0;
    
    for(int i=0; i<array.Length; i++)
    {
        if(i%2!=0)
        {
            sum+=array[i];
        }
    }
    return sum;
}
//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

var arr =FillArray(10);
Print(arr);
Console.WriteLine();
var count= CountEvenNum(arr);
System.Console.WriteLine(count);

int[] FillArray(int lenght)
{
    int[] array = new int[lenght];
    for(int i=0; i < lenght; i++)
    {
        array[i] =new Random().Next(100, 1000);
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
int CountEvenNum(int[] array)
{
    int count = 0;
    
    foreach(int item in array)
    {
        if(item%2==0)
        {
            count++;
        }
    }
    return count;
}
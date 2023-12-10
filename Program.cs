Задайте одномерный массив из 10 целых чисел от 1 до 100. 
Найдите количество элементов массива, 
значения которых лежат в отрезке [20,90].

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i]+ " ");

    if(array[i] >=20 && array[i] <=90)
    {
        count = count +1;
    }
}

Console.WriteLine();
Console.WriteLine (count); 




Задайте массив на 10 целых чисел. 
Напишите программу, которая определяет 
количество чётных чисел в массиве.

int[] array = new int[10];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 40);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine(count);





Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];
double max = 0;
double min = 100;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 100;
    Console.WriteLine(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max) max = array[i];
}
Console.WriteLine();
Console.WriteLine("максимальное число " + max);

for (int i = 0; i < array.Length; i++)
{
    if(array[i] < min) min = array[i];
}
Console.WriteLine();
Console.WriteLine("минимальное число " + min);

Console.WriteLine();
Console.WriteLine("разница " + (max - min));





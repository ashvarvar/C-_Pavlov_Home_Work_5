﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите размер массива :   ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int SizeArray)
{
    int[] array = new int[SizeArray];
    for (int i = 0; i < SizeArray; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}


void PrintArray(int[] array)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < SizeArray; i++)
    {
        Console.Write(array[i] + " ");
        if (i % 2 > 0)  // именно четную позицию вычисляем
            {
            sum += array[i];
            }
        
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел, стоящих на четной позиции, соcтаваляет {sum} ");
}

PrintArray(FillArray(SizeArray));

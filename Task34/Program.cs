//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива :   ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int SizeArray)
{
    int[] array = new int[SizeArray];
    for (int i = 0; i < SizeArray; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int chet = 0;
    int NEchet = 0;
    for (int i = 0; i < SizeArray; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) 
        chet++;
        else NEchet++;
    }
    Console.WriteLine($"Количество четных чисел {chet}, количество нечетных чисел {NEchet}");
  }

PrintResult(FillArray(SizeArray));

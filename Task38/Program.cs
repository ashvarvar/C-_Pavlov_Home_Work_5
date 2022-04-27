// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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


void PrintMyArray(int[] array)
{
    for (int i = 0; i < SizeArray; i++)
    {
            Console.WriteLine(array[i] + " ");
    }
    int difference = array.Max() - array.Min();
        Console.WriteLine($"Min значение массива: {array.Min()} , Max значение массива:  {array.Max()}");
        Console.WriteLine($"Разница между Min и Max :   {difference}");
}
PrintMyArray(FillArray(SizeArray));

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int SetNumber(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] FillArray(int size, int minVolume, int maxVolume)
{
    int[] array = new int[size];
    int i = 0;
    Random rand = new Random();

    for (i = 0; i < size; i++)
    {
        array[i] = rand.Next(minVolume, maxVolume + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int i = 0;
    System.Console.Write("[");
    for (i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}");
        if (i != array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int EvenArray(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }

    return result;
}



int size = SetNumber("Задайте размерность массива");
int[] arrayEven = FillArray(size, 100, 999);
PrintArray(arrayEven);
System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных элементов массива = {EvenArray(arrayEven)}");

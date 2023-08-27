// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int OddArraySum(int[] array)
{
    int result = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }

    return result;
}



int size = SetNumber("Задайте размерность массива");
int min = SetNumber("Задайте начало числового диапапзона");
int max = SetNumber("Задайте конец числового диапазона");
int[] arrayOddSum = FillArray(size, min, max);
PrintArray(arrayOddSum);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечётных элементов массива = {OddArraySum(arrayOddSum)}");

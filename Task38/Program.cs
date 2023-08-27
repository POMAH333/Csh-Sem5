// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int SetNumber(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[] FillArrayDouble(int size, int minVolume, int maxVolume)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble() * (maxVolume - minVolume) + minVolume;
    }
    return array;
}

void PrintArray(double[] array)
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

double ArrayMin(double[] array)
{
    double result = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < result) result = array[i];
    }

    return result;
}

double ArrayMax(double[] array)
{
    double result = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > result) result = array[i];
    }

    return result;
}



int size = SetNumber("Задайте размерность массива");
int min = SetNumber("Задайте начало числового диапапзона");
int max = SetNumber("Задайте конец числового диапазона");
double[] arraySub = FillArrayDouble(size, min, max);
PrintArray(arraySub);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {ArrayMax(arraySub) - ArrayMin(arraySub)}");

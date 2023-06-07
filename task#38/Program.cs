// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



void InputArray(double[] array)
{
    int end = 100, begin = 0;
    for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
}

//void Diff(int[] array);
int[] diff(int[] result, int[] imax, int[] imin)
{
    // int imax = 0;
    // int imin = 0;

    for (int i = 0; i < array.Length; i++);
    result[i] = imax[i] - imin[i];
    return result;
}

Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(": ", array)}]");

Console.WriteLine($"Результат: {string.Join(diff(array, imax, imin))}");






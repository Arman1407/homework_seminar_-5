// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



void InputArray(double[] array)
{
int end = 100, begin = 0;
for (int i = 0; i < array.Length; i++)
array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
}

void diff(double[] array)
{
    double max = array[0];
    double min = array[0];
    double difference = array[0];

    for (int i = 0; i < array.Length; i++)
    
    if(array[i] > max)
    {
        max = array[i];
    }
    else if(array[i] < min)
    {
        min = array[i];
    }
    
    difference = max - min;

    Console.WriteLine("максимальный элемент массива: " + max);
    Console.WriteLine("минимальный элемент массива: " + min);
    Console.WriteLine("разница максимального и минимального элементов массива: " + difference);
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
diff(array);
//Console.WriteLine($"{string.Join({max} - {min} = {difference})}");





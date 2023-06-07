// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-100, 101); 
}

void summa(int[] array)
{
int Positivеsum = 0;
int count = 0;
foreach (int element in array)
{
if (element != element % 2)
count ++;
Positivеsum += count;
}
Console.WriteLine($"Сумма не четных элементов массива: {Positivеsum}"); 
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
summa(array);



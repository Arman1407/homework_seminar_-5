// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-100, 101); // [-9; 9]
}

void Summa(int[] array)
{
int summa = 0;                       // int sumPositivе = 0, allSum = 0;
foreach (int element in array)
{
if (element % 2 == 1)
summa += element + 2;
                                    //allSum += element;
}
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = {summa}");
// Console.WriteLine($"Сумма отрицательных чисел равна: {allSum - sumPositivе}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Summa(array);



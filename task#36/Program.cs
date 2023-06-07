// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-100, 101); // [-9; 9]
}

int[] Summa(int[] array, int[] result)
{
for (int i = 0; i < result.Length; i++)
result[i] = result[i] % 2;
return result;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = {(", ", Summa(array, result))}");


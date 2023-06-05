﻿// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000); // [-9; 9]
}

void Search(int[] array)
{
int Positivе = 0;
foreach (int element in array)
{
if (element % 2 == 0)
Positivе ++;
}
Console.WriteLine($"Количество четных чисел: {Positivе}"); 
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Search(array);

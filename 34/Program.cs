//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

void InputArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int Release(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] %2 == 0)
        count++;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Console.Clear();
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($" = {Release(array)}");


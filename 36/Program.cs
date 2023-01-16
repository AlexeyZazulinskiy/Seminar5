//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

void InputArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

int Release(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i= i+2){
        sum = sum + array[i];
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Console.Clear();
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($" = {Release(array)}");


//Задача 38: Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

void InputArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

int Release(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++){
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($" max {max}, min {min}");
    return (max -Math.Abs(min));
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Console.Clear();
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($" = {Release(array)}");

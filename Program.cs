// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] array = new double[5];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100);
Print(array);

double max = 0;
double min = 0;

foreach (double i in array)
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.Write($"-> {max - min}\n");





//for (int i = 0; i < array.Length; i++)
//{
//if (array[i] > max)
//{
//    max = array[i];
//}
//if (array[i] < min)
//{
//    min = array[i];
//}
//  Console.WriteLine("Разница максимального и минимального:  " + (max - min));
//}
















void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
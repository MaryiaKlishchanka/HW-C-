// Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным
//элементов массива;

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);  
}


double[] CreateFillArray(int size)
{
    double[] array = new double[size];
    Random rnd= new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rnd.Next(1, 100) + rnd.NextDouble(), 3);  
    return array;
}


double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] <min)
            min = array[i];
    }
    return min;   
}
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;   
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int size = InputNum("Введите размер массива: ");
double[] array = CreateFillArray(size);
PrintArray(array);
double min = FindMin(array);
Console.WriteLine($"минимальное число в массиве {min}");
double max = FindMax(array);
Console.WriteLine($"максимальное число в массиве {max}");
Console.WriteLine($"разница между асмальным и минимальным элементами массива равна {max - min}");
      

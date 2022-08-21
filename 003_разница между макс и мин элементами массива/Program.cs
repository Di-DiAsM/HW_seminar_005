// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.Clear();

Console.WriteLine("Введите массив: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double [size];

Fillarray(numbers);
PrintArray(numbers);

double min = numbers[0];
double max = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] < min)
    {
        min = numbers[i];
    }
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine($"минимальное число: {min}");
Console.WriteLine($"максимальное число: {max}");

double result = max - min;

Console.WriteLine($"Разницу между максимальным и минимальным элементами массива: {result}");
Console.WriteLine($"Разницу между максимальным и минимальным элементами массива: {Math.Round(result, 2)}");

void Fillarray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    numbers[i] = new Random().Next(10, 1000)/10.0; // диапозон от 1 до 100. в общем логика делим на вещественное число, результат числа становится вещественным.
                                                // но можно и отсечь через Math.Round() - который не проходили. Можно просто сделать new Random().NextDouble(); заполнение любыми вещественными значениями.   
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}



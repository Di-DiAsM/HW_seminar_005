// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

Console.WriteLine("Введите массив: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];

// int[] numbers = { 231, 453, 653, 977 }; // проверял выведет ли "0"

FillArray(numbers);
PrintArray(numbers);

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 ==0)
    {
        Console.Write(numbers[i] + " ");
        count++;
    }
}

Console.WriteLine($"- количество чётных чисел в массиве: {count}");

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    numbers[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

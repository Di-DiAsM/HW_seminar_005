// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] numbers = new int[6];

//int[] numbers = { 3, 7, 23, 12 };    //проверка
// int[] numbers = {-4, -6, 89, 6};

Fillarray(numbers);
PrintArray(numbers);

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if(i % 2 != 0)
    {
        sum += numbers[i];
        Console.Write(numbers[i] + " ");
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");


void Fillarray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    numbers[i] = new Random().Next(-10, 100);
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
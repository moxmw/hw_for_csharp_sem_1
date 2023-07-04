// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите три числа:");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());
    int maxNum = Math.Max(Math.Max(num1, num2), num3);
Console.WriteLine($"Максимальное число: {maxNum}");
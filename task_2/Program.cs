// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число:");
    int num1 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите второе число:");
    int num2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (num1 > num2)
{
    Console.WriteLine("Первое число больше второго.");
    Console.WriteLine("Большее число: " + num1);
    Console.WriteLine("Меньшее число: " + num2);
}
else if (num1 < num2)
{
    Console.WriteLine("Второе число больше первого.");
    Console.WriteLine("Меньшее число: " + num1);
    Console.WriteLine("Большее число: " + num2);
}
else
{
    Console.WriteLine("Оба числа равны.");
    Console.WriteLine("Число: " + num1);
}
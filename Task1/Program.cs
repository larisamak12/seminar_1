// Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number_2 = Convert.ToInt32(Console.ReadLine());


int max = number_1;
int min =number_2;

if (number_1 > number_2 ) max = number_1;
if (number_2 > number_1 ) max = number_2;
if (number_1 < number_2 ) min = number_1;
if (number_2 < number_1 ) min = number_2;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
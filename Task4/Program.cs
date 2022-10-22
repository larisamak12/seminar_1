// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число a: "); 
int number_a = Convert.ToInt32(Console.ReadLine()); 
 
Console.Write("Введите число b: "); 
int number_b = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите число c: "); 
int number_c = Convert.ToInt32(Console.ReadLine()); 

int max = number_a;

if(number_a>max) max = number_a;
if(number_b>max) max = number_b;
if(number_c>max) max = number_c;

Console.Write("max=");
Console.WriteLine(max);  
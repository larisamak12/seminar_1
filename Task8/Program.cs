// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int number_a = 1;

while (number_a <= n){ 
    if(number_a%2 == 0){
    Console.WriteLine(number_a);
} 
    number_a++; 
}
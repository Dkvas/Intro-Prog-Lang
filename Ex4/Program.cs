//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

//using static System.Console;

Console.Clear();
Console.WriteLine("Все чётные числа до N.");
Console.Write("Введите число N: ");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=1;

while (num2<=num1)
{
    Console.Write($"{num2} ");
    num2=num2+1;
}
// Понял как получать список, не понял как в дальнейшем этот список брать, чтобы выбрать четные значения.
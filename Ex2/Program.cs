//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Сравниваем три числа.");
Console.Write("Введите число 1: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3=Convert.ToInt32(Console.ReadLine());
int num1=max;
if(num1<num2)num2=max;
if(num2<num3)num3=max;
Console.WriteLine(max);
// Не понял, как пользоваться переменной "max" - программа не работает
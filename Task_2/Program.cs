//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter first number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number > number2 && number > number3)
{
    Console.WriteLine("Max number: " + number);
}
if (number2 > number && number2 > number3)
{
    Console.WriteLine("Max number: " + number2);
}
if (number3 > number && number3 > number2)
{
    Console.WriteLine("Max number: " + number3);
}

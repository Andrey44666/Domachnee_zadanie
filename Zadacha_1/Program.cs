/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Enter two number :");
string strnumberA = Console.ReadLine();
int numberA = Convert.ToInt32(strnumberA);

string strnumberB = Console.ReadLine();
int numberB = Convert.ToInt32(strnumberB);

if (numberA > numberB)
{
  Console.Write("max = ");
  Console.WriteLine(numberA);
  Console.Write("min = ");
  Console.WriteLine(numberB);
}
else
{
  Console.Write("max = ");
  Console.WriteLine(numberB);
  Console.Write("min = ");
  Console.WriteLine(numberA);
}
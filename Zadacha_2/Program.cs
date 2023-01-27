/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Enter two number :");
string strnumberA = Console.ReadLine();
int numberA = Convert.ToInt32(strnumberA);
string strnumberB = Console.ReadLine();
int numberB = Convert.ToInt32(strnumberB);
string strnumberC = Console.ReadLine();
int numberC = Convert.ToInt32(strnumberC);
int max = numberA;
if (numberA>max) max = numberA;
if (numberB>max) max = numberB;
if (numberC>max) max = numberC;
System.Console.Write("max = ");
System.Console.WriteLine(max);
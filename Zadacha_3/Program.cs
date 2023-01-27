/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Enter numbers :");
string strnumberA = Console.ReadLine();
int numberA = Convert.ToInt32(strnumberA);
if (numberA % 2 == 0)
{
    System.Console.WriteLine("entered number even");
}
else
{
    System.Console.WriteLine("entered number not even");
}
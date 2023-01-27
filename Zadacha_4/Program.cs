/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Enter number :");
string strnuber = Console.ReadLine();
int number = System.Convert.ToInt32(strnuber);
int result = 1;
while (result < number)
{
    System.Console.WriteLine(result + 1);
    result +=2;
}

/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/

string recursion (int n, int m)
{
    if(n==m)
        return m.ToString();
    else
        return n + "," + recursion(n+1, m);
}
Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите число m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine($"{recursion(n,m)} ");

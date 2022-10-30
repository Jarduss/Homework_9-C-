/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

System.Console.Write("Введите A ");
int A = int.Parse(Console.ReadLine());
System.Console.Write("Введите B ");
int B = int.Parse(Console.ReadLine());
void getNumbersMN(int A, int B, int sum)
{
    if (A>= B)
    {
        if (A == B) 
        {
            System.Console.WriteLine(A);
            System.Console.WriteLine(" ");
            System.Console.WriteLine($"Сумма чисел в промежутке от числа А до числа В составляет: {sum + A}");
            return;
        }
        else 
        {
        sum = sum + A;
        System.Console.WriteLine(A);
        A-=1;     
        getNumbersMN(A,B,sum);
        }
    }
    else System.Console.WriteLine($"{B} > {A} введите правильные данные");
} 
getNumbersMN(A,B, 0);

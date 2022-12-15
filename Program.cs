//Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N
/*
void ShowNumbers(int n)
{
    if(n>1) ShowNumbers(n - 1);
    Console.Write(n + " ");
}
ShowNumbers(5);
*/

//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumDigits(int num)
{
    if(num < 0) num *= (-1);
    if(num > 0) return SumDigits(num / 10) + num % 10;
    else return 0;
}
Console.WriteLine("Input num:");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigits(number);
Console.WriteLine(result);
*/

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
// N < M, N = M, M < N
/*
void ShowNumbersMN(int n, int m)
{
    if(Math.Max(n,m) != Math.Min(n,m)) ShowNumbersMN(Math.Max(n,m), Math.Min(n,m)+1);
    Console.Write($"{Math.Min(n,m)}"); 
//Math.Max(n,m) Math.Min(n,m)    
}
ShowNumbersMN(8,5);
*/

//Напишите программу, которая на вход принимает два числа A и B,
//и возводит число А в степень B с помощью рекурсии.
/*
double APowB(int a, int b)
{
    if(b>0) return APowB(a, b - 1) *a;
    if(b<0) return APowB(a, b + 1) /a;
    return 1.0;
}

double res = APowB(2, -5);
Console.Write(res);
*/


//Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
Console.WriteLine("Input number > 0:");
int number = Convert.ToInt32(Console.ReadLine());

void Order (int number)
{
    if (number < 0) return;
    Console.Write("is not natural");
    if (number == 0) return;
    Console.Write("{0, 3}", number);
    Order (number - 1);
}

Order(number);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
void SummFromMToN(int m, int n)
{
    Console.Write(SummMN(m - 1, n));
}

int SummMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SummMN(m, n);
        return result;
    }
}
Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

SummFromMToN(m, n);
*/
//Задача 68: дополнительно Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
/*
Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int functionAckerman = Ack(m, n);

Console.Write($"Ackerman = {functionAckerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
*/

//Задача: Написать рекурсивную функцию перевода из 
//десятичной системы исчисления в двоичную
/*
string BinarSyst(int num)
{
    string binresult = string.Empty;
    while(num != 0)      
    {
        binresult = num % 2 + binresult;
        num /= 2;
    }
    return binresult;
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
string res = BinarSyst(number);
Console.WriteLine($"your number {number} in binar syst is {res}");
*/
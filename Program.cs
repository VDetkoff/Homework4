/*
//Домашняя работа 1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double DegreeNum (double a, double b)
{
   double c = Math.Pow(a,b);
   return c;
}

Console.Write("Input number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Raise a number to a power: ");
double b = Convert.ToDouble(Console.ReadLine());


Console.WriteLine($"{a} to the degree {b} equal {DegreeNum (a, b)}{"!"}");
*/
/*
// Домащняя работа 2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

static int SumDigit(int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}   
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumDigit = SumDigit(num);
Console.WriteLine($"Sum digits in number: {sumDigit}");
*/
/*
//Домашняя работа 2 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int [] CreateArrey(int n)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(n);
    }
    return arr;
}
void PrintArrey(int [] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i] }, ");
    Console.Write("\b\b]");
}
PrintArrey(CreateArrey(8));
*/

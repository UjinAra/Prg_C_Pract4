// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
using static System.Console;
Clear(); 

WriteLine("Введите число N");
int N = Convert.ToInt32(ReadLine());
int result=0;

while (N > 0)
{
int Cif=N % 10;
N = N /10;
result = result + Cif;
}
WriteLine("Результат = " + result);
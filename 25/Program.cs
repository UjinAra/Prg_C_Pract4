// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear(); 

WriteLine("Введите число А");
int A = Convert.ToInt32(ReadLine());

WriteLine("Введите число B");
int B = Convert.ToInt32(ReadLine());

int Kub=A;
for (int i=1; i<B; i++)
{
    Kub =Kub * A ;
}
WriteLine("Число А в степени B = " + Kub );

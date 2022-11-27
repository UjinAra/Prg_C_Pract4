// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using static System.Console;
Clear(); 
WriteLine("Введите длинну массива N");
int N = Convert.ToInt32(ReadLine());
WriteLine("Введите начало диапазона произвольных чисел n1");
int n1 = Convert.ToInt32(ReadLine());
WriteLine("Введите конец диапазона произвольных чисел n2");
int n2 = Convert.ToInt32(ReadLine());

void FillMass(int[] mass)
{
    for (int i=0 ; i < N; i++)
    mass[i]= new Random().Next (n1,n2);
}
void PrintMass(int[] mass)
{
    for (int i=0 ; i < N; i++)
    Write($" {mass[i]} ");
}

int [] mass = new int [N]; // N - Размерность строки
FillMass(mass);
PrintMass(mass);
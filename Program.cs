// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/
Console.WriteLine("Введите число");
 
int N = int.Parse(Console.ReadLine());

if (N % 2 == 0 ){
    Console.WriteLine("Число чётное");
}

else {
Console.WriteLine( "Число нечётное");
}
﻿//Задача 6: Напишите программу,
//которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).



Console.Write("Введите числовое значение: ");
var n = int.Parse (Console.ReadLine());

if ( n % 2 == 0){
Console.WriteLine("Число является четным: ");
Console.Write(n);
}
            else 
            Console.Write("Число не является четным: ");
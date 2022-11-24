// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

//Console.WriteLine(" Введите трехзначное число") ;
//int number = Convert.ToInt32(Console.ReadLine()) ;
//int sl1=number/100 ;
//sl1=sl1*10+number%10 ;
//Console.WriteLine(sl1) ;



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

//Console.Write(" Введите первое число ") ;
//int num1 = Convert.ToInt32(Console.ReadLine()) ;
//Console.Write(" Введите второе число ") ;
//int num2 = Convert.ToInt32(Console.ReadLine()) ;
//int ostat = num2%num1 ;
//if(ostat == 0)
//  Console.WriteLine(" число два кратно числу один ") ;
//else 
//Console.WriteLine($" числа два не кратно числу один, остаток {ostat}") ;



//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

//Console.Write(" Введите число ") ;
//int num = Convert.ToInt32(Console.ReadLine()) ;
//if(num%7 == 0 && num%23 == 0)
//  Console.WriteLine($" число  {num} КРАТНО 7 и 23 ") ;
//else 
//  Console.WriteLine($" число  {num}  НЕ КРАТНО 7 и 23") ;



//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write(" Введите первое число ") ;
int num1 = Convert.ToInt32(Console.ReadLine()) ;
Console.Write(" Введите второе число ") ;
int num2 = Convert.ToInt32(Console.ReadLine()) ;
if(num1 == (int)Math.Pow(num2, 2))
  Console.WriteLine($" первое число {num1} явл. квадратом второго {num2}") ;
else 
{
if(num2 == (int)Math.Pow(num1, 2))
  Console.WriteLine($" второе число {num2} явл. квадратом первого {num1}") ; 
else  
 Console.WriteLine($" числа {num1} {num2}   не явл. квадратами друг друга") ;
}
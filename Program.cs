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

//Console.Write(" Введите первое число ") ;
//int num1 = Convert.ToInt32(Console.ReadLine()) ;
//Console.Write(" Введите второе число ") ;
//int num2 = Convert.ToInt32(Console.ReadLine()) ;
//if(num1 == (int)Math.Pow(num2, 2))
//  Console.WriteLine($" первое число {num1} явл. квадратом второго {num2}") ;
//else 
//{
//if(num2 == (int)Math.Pow(num1, 2))
//  Console.WriteLine($" второе число {num2} явл. квадратом первого {num1}") ; 
//else  
// Console.WriteLine($" числа {num1} {num2}   не явл. квадратами друг друга") ;
//}



// дано натуральное n. вычислить: 1 + 1/2 + 1/3 + 1/4 + ... + 1/n.

//Console.Write(" Введите натурально число N не равное нулю ") ;
//int n = Convert.ToInt32(Console.ReadLine()) ;
//double result = 0 ;
//for (double i=1; i<=n; i++)
//{
// result= result + 1/i ;
//}
//Console.WriteLine($" результат {result}") ;



//Вычислить : 1+2+4+8+...+ N в 10 степени

//Console.Write(" Введите натурально число N ") ;
//int n = Convert.ToInt32(Console.ReadLine()) ;
//double result=0 ;
//for ( int i=0; i<=n; i++)
//{
 //if (i>0 && i<2) 
 // result = result+1 ;
 //else 
 //{
 // if (i%2 == 0)
 //   result=result+i ;
 //} 
//}
//Console.WriteLine(result) ;
//result =(double)Math.Pow(result, 10) ;
//Console.WriteLine($" результат {result}") ;



// Вычилислить сумму ряда с указанной точность (е = 0.001) 
//1 + 1/2 + 1/3 + 1/4 + ... + 1/бесконечность.
//если последнее точность последнего действия меньше чем e , завершаем цикл с помощью break

//Console.Write(" Введите натурально число N не равное нулю ") ;
//int n = Convert.ToInt32(Console.ReadLine()) ;
//Console.Write(" Введите точность ряда ( например 0,001) ") ;
//double esp = Convert.ToDouble(Console.ReadLine()) ;
//double LastOper=1 ;
//double result = 0 ;
//double i=1 ;
//for ( i=1; i<=n; i++)
//{ 
//  if( LastOper <= esp )
//    break ;
//result= result + 1/i ; 
//LastOper=1/i ;
//}
//Console.WriteLine($" точность c коротой было вычесленно значение ряда  {LastOper}") ;
//Console.WriteLine($" сумма элементов {result}") ;



//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Write(" Введите трехзначное число  ") ;
int number = Convert.ToInt32(Console.ReadLine()) ;
int sl1=(number/10)%10 ;
Console.WriteLine($" вторая цифра числа {number} -> {sl1} ") ;
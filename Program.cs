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

Console.Write(" Введите первое число ") ;
int num1 = Convert.ToInt32(Console.ReadLine()) ;
Console.Write(" Введите второе число ") ;
int num2 = Convert.ToInt32(Console.ReadLine()) ;
int ostat = num2%num1 ;
if(ostat == 0)
  Console.WriteLine(" число два кратно числу один ") ;
else 
Console.WriteLine($" числа два не кратно числу один, остаток {ostat}") ;


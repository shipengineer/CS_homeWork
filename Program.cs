﻿/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
// try {
// Console.WriteLine("Введите число а = ");
// long a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b = ");
// long b = Convert.ToInt32(Console.ReadLine());

// if (a>b)
// {
//     Console.WriteLine("max = " + a);
// } else if (a<b) {
//     Console.WriteLine("max = " + b);
// } else  {
//     Console.WriteLine("Числа равны");
// }
// } catch {
//     Console.WriteLine("Вводите, пожалуйста, целые числа");
// }

//-------------------------------------------------------------------------------------------------------------------------------------------------------

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

//[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

// try{
// Console.Write("Введите первое число = ");
// long num1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите второе число = ");
//     long num2 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите третье число = ");
//         long num3 = Convert.ToInt32(Console.ReadLine());
// long max = num1;

// if (num2>max)
// {
//     max = num2;
// } else if (num3>max){
//     max = num3;
// } 
// Console.WriteLine(num1 +", "+ num2 +", "+ num3 +" -> "+max);
// } catch {
//     Console.WriteLine("Вводите, пожалуйста, целые числа");
// }

//-------------------------------------------------------------------------------------------------------------------------------------------------------

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

//[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

// Console.Write("Введите число на проверку чёт/ нечет = ");
// long num4 = Convert.ToInt32(Console.ReadLine());

// if (num4%2 == 0)
// {
// Console.Write($"Число {num4} четное");
// } else {
// Console.Write($"Число {num4} Нечетное");
// }

//-------------------------------------------------------------------------------------------------------------------------------------------------------

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

//[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

// Console.Write("Введите число для обработки  = ");
// long N = Convert.ToInt32(Console.ReadLine());
// long i = 0;
// while(i <= N)
// {

// Console.Write(i + ", ");
// i+= 2;
// }

//-------------------------------------------------------------------------------------------------------------------------------------------------------

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

//[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

// void scndCount(long num)
// {
//     long result = (num % 100 - num % 10) / 10;
//     System.Console.WriteLine(result);
// }

// Console.Write("Введите число: ");
// long num = long.Parse(Console.ReadLine());

// scndCount(num);
//-------------------------------------------------------------------------------------------------------------------------------------------------------

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

/*
void thrdCount(long num)
{
    long origin = num;
    long mutable = num;
    long i = 0;
    if (num > 99 && num != 0)
    {
        while (mutable > 999)
        {
            mutable = mutable / 10;
            i++;
        }
        long result = (origin / Convert.ToInt32(Math.Pow(10, i))) % 10;
        System.Console.WriteLine("________________________________________________________________________________________________________________");
        System.Console.WriteLine($"Третья цифра числа {origin} это {result}\n");
    }
    else if (num == 0)
    {
        System.Console.WriteLine("________________________________________________________________________________________________________________");
        System.Console.WriteLine("Ну тут варианта два: \n");
        System.Console.WriteLine("1. Ты либо ввел чсило больше чем может принять 32 разрядный long, а это <<От -2 147 483 648 до 2 147 483 647>>");
        System.Console.WriteLine("2. Ты вообще ввел не число, хулиган ('v') \n");
    }
    else
    {
        System.Console.WriteLine("________________________________________________________________________________________________________________");
        System.Console.WriteLine("У числа нет тертьей цифры, но ты об этом и сам знаешь");

    }
}

Console.Write("Введите число: ");
long.TryParse(Console.ReadLine(), out long num);

thrdCount(num);
*/

//-------------------------------------------------------------------------------------------------------------------------------------------------------
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
//[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
/*
void weekEnd(long num)
{
    if (0 < num && num <= 7)
    {
        if (num > 5)
        {
            System.Console.WriteLine($"{num} -> да");
        }
        else System.Console.WriteLine($"{num} -> нет");
    }
    else
    {
        System.Console.WriteLine("_____________________________________________________________________________");
        System.Console.WriteLine("Зачем вы ввели не день недели");

    }
}
Console.Write("Введите цифру дня недели: ");
long.TryParse(Console.ReadLine(), out long num);
weekEnd(num);
*/
//-------------------------------------------------------------------------------------------------------------------------------------------------------

/*Задача 11 HARD - необязательная: Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого
числа.*/

//[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
void thrdCount(long num)
{
    if (num > 99 && num != 0)
    {
        while (mutable > 99)
        {
            mutable = mutable / 10;
            i++;
        }

        long result = (origin - origin % Convert.ToInt64(Math.Pow(10, i + 1))) / 10 + origin % Convert.ToInt64(Math.Pow(10, i));
        System.Console.WriteLine($"Было:  {origin}");
        System.Console.WriteLine($"Стало: {result}");
    }
    else if (num == 0)
    {
        System.Console.WriteLine("________________________________________________________________________________________________________________");
        System.Console.WriteLine("Ну тут варианта три: \n");
        System.Console.WriteLine("1. Ты либо ввел чсило больше чем может принять 64 разрядный long, а это <<От -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807>>");
        System.Console.WriteLine("2. Ты вообще ввел не число, хулиган ('v') ");
        System.Console.WriteLine("3. Ты ввел число \"0\"\n");

    }
    else
    {
        System.Console.WriteLine("________________________________________________________________________________________________________________");
        System.Console.WriteLine("У числа нет второй цифры, но ты об этом и сам знаешь");
    }

}
void positiveSolution(long num)
{
    if (num > 99 && num != 0)
    {
        while (mutable > 99)
        {
            mutable = mutable / 10;
            i++;
        }

        long result = (origin - origin % Convert.ToInt64(Math.Pow(10, i + 1))) / 10 + origin % Convert.ToInt64(Math.Pow(10, i));
        System.Console.WriteLine($"Было:  {origin}");
        System.Console.WriteLine($"Стало: {result}");
    }
    else if (num == 0)
    {
        System.Console.WriteLine("________________________________________________________________________________________________________________");
        System.Console.WriteLine("Ну тут варианта три: \n");
        System.Console.WriteLine("1. Ты либо ввел чсило больше чем может принять 64 разрядный long, а это <<От -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807>>");
        System.Console.WriteLine("2. Ты вообще ввел не число, хулиган ('v') ");
        System.Console.WriteLine("3. Ты ввел число \"0\"\n");

    }
    else
    {
        System.Console.WriteLine("________________________________________________________________________________________________________________");
        System.Console.WriteLine("У числа нет второй цифры, но ты об этом и сам знаешь");
    }

}
void negativeSolution(long num)
{
    if (num < -99 && num != 0)
    {
        while (mutable < -99)
        {
            mutable = mutable / 10;
            i++;
        }

        long result = (origin + origin % Convert.ToInt64(Math.Pow(10, i + 1))) / 10 - origin % Convert.ToInt64(Math.Pow(10, i));
        System.Console.WriteLine($"Было:  {origin}");
        System.Console.WriteLine($"Стало: {result}");
    }
    else if (num == 0)
    {
        System.Console.WriteLine("________________________________________________________________________________________________________________");
        System.Console.WriteLine("Ну тут варианта три: \n");
        System.Console.WriteLine("1. Ты либо ввел чсило больше чем может принять 64 разрядный long, а это <<От -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807>>");
        System.Console.WriteLine("2. Ты вообще ввел не число, хулиган ('v') ");
        System.Console.WriteLine("3. Ты ввел число \"0\"\n");

    }
    else
    {
        System.Console.WriteLine("________________________________________________________________________________________________________________");
        System.Console.WriteLine("У числа нет второй цифры, но ты об этом и сам знаешь");
    }

}

Console.Write("Введите число: ");
Int64.TryParse(Console.ReadLine(), out long num);
Console.Write("Введите число: ");
Int64.TryParse(Console.ReadLine(), out long num);
Console.Write("Введите число: ");
Int64.TryParse(Console.ReadLine(), out long num);

// Предельное число long  типа 9223372036854775807
thrdCount(num);


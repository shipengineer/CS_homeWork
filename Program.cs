/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
// try {
// Console.WriteLine("Введите число а = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b = ");
// int b = Convert.ToInt32(Console.ReadLine());

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


/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
// try{
// Console.Write("Введите первое число = ");
// int num1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите второе число = ");
//     int num2 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите третье число = ");
//         int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;

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



/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
// Console.Write("Введите число на проверку чёт/ нечет = ");
// int num4 = Convert.ToInt32(Console.ReadLine());

// if (num4%2 == 0)
// {
// Console.Write($"Число {num4} четное");
// } else {
// Console.Write($"Число {num4} Нечетное");
// }

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

// Console.Write("Введите число для обработки  = ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// while(i <= N)
// {

// Console.Write(i + ", ");
// i+= 2;
// }

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

void scndCount(int num)
{
    int result = (num % 100 - num % 10) / 10;
    System.Console.WriteLine(result);
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

scndCount(num);


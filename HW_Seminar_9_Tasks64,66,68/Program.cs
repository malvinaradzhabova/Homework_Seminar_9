/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
/* 
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число: ");
        int numberN = Convert.ToInt32(Console.ReadLine());
        int numberA = 1;

         if (numberN < 1)
           {
              Console.WriteLine("Отрицательное число");
           }
        Console.WriteLine(NaturalNumber(numberN, numberA));


        int NaturalNumber(int numberN, int numberA)
        {

            if (numberN == numberA)
            {
                return numberN;
            }
            else
            {
                Console.Write($"{NaturalNumber(numberN, numberA + 1)}, ");
            }
            return numberA;
        }
    }
}
 */



/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */



/* 
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число M: ");
        int numberM = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите натуральное число N: ");
        int numberN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(SumOfNumber(numberM, numberN));
         
        int SumOfNumber(int numberM, int numberN)
        {

            if (numberM == numberN)
            {
                return numberN;
            }
            else
            {
             return numberN+SumOfNumber(numberM, numberN - 1);
            }
        }
    }
}

 */



/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

/* 
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число M: ");
        int numberM = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите натуральное число N: ");
        int numberN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Akkerman(numberM, numberN));

        int Akkerman(int numberM, int numberN)
        {
            if (numberM == 0)
              {
                return numberN + 1;
              }
            if (numberM > 0  &&  numberN == 0)
              {
                  return Akkerman(numberM - 1, 1);
              }
            else
              {  
                return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));
              }
        }
    }
}
 */
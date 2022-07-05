// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


namespace HomeWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int numberN = Convert.ToInt32(Console.ReadLine());
            
            if (numberN < 10000 || numberN > 99999) 
            {                                  
                Console.WriteLine("This number is not polindrom length five");
            } 
            else if (numberN % 10 == numberN / 10000 & (numberN / 10) % 10 == (numberN / 1000) % 10) 
            {
                Console.WriteLine("Yes");
            } 
            else 
            {
                Console.WriteLine("No");
            }
        
        }
    }
}

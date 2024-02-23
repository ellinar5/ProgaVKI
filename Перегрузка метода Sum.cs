using System;

namespace Перегружка_метода_Sum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("  1) Сумма целочисленных числ 10 и 6");
            Console.WriteLine("  2) Сумма значений строк Hello и World!");
            Console.WriteLine("  3) Сумма значений в массиве (заполнен рандомно):");
            Console.WriteLine("  4) Сумма числа с плавающей точкой и строки:");
            Console.WriteLine("Выбирите один из пуктов для выполнения задания:");
            int admine = int.Parse(Console.ReadLine());

            switch(admine)
            {
                case 1:
                    Sum(10, 6);
                    break;

                case 2:
                    Sum("letter1", "letter2");
                    break;
                case 3:
                    Sum();
                    break; 
                
                case 4:
                    double number = 42.0;
                    string word = "forty-two";

                    Sum(number, word);

                    number = 0.1;
                    word = "one tenth";

                    Sum(number, word);
                    break;

                default:
                    Console.WriteLine("Вы ввели несуществующий номер задания");
                    break;

            }
            
        }

        private static void Sum(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
        
        }

        private static void Sum (string letter1, string letter2)
        {
            string str1 = "Hello";
            string str2 = " World!";
            string sum = str1 + str2;
            Console.WriteLine(sum);
        }

        private static void Sum ()            
        {                                              
            Console.Write("Ввидите длину массива: ");          
            int n = Convert.ToInt32(Console.ReadLine());
            int[] massiv = new int[n];
            Random random = new Random(); 
                                          
                                          
            for (int i = 0; i < n; i++)
            {
                massiv[i] = random.Next(-10, 100);
                Console.WriteLine(massiv[i] + " ");
            }
            Console.WriteLine(" ");

            int sum = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                
                sum = sum + massiv[i];

            }
            Console.WriteLine(sum);
        }

        private static void Sum(double number, string word)
        {
            try                                                                                   //Блок try…catch используется
            {                                                                                     //для обработки возможных исключений,
                number += double.Parse(word);                                                     //которые могут возникнуть при преобразовании строки в число.                                         
                Console.WriteLine($"Преобразование прошло успешно. Новая сумма: {number}");       //Если исключение не обрабатывается, программа может аварийно завершиться.  
            }
            catch
            {
                Console.WriteLine("Преобразование не удолось: 0");
            }
        }
    }
}

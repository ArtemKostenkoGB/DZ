using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Z25()
            {
                int a = 8;
                int b = 2;
                int result = a;

                for (int i = 1; i < b; i++)
                {
                    result *= a;
                }
                Console.WriteLine(result);
            }


            void Z27()
            {
                int number = 24987;
                SumOfDigits(number);
            }

            void SumOfDigits(int numb)
            {
                int sum = 0;
                Console.Write(" сумма цифр числа " + numb);
                while(numb > 0)
                {
                    sum += numb%10;
                    numb /= 10;
                }
                Console.WriteLine(" равна " + sum);

            }

            void Z29()
            {
                int size = 8;
                int [] array = new int [size];

                Random random = new Random();
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-10, 10);
                    Console.Write(array[i] + "  ");
                }
                Console.WriteLine();
            }

            Z25();
            Z27();
            Z29();
        }
    }
}
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            void Z19()
            {

            int number = 23432;

            if (number > 9999 && number <100000)
            {
                int digitOne = number % 10;
                int digitTen = number / 10 % 10;
                int digitThousand = number / 1000 % 10;
                int digitTenThousand = number / 10000;
                if (digitOne == digitTenThousand && digitTen == digitThousand)
                {
                    Console.WriteLine ("число палиндром");
                }
                else
                {
                    Console.WriteLine ("число не палиндром");
                }
            }
            else 
            {
                Console.WriteLine ("введено неверное число");
            }
        }

            void Z21()
            {
                int a_x = 3;
                int a_y = 6;
                int a_z = 8;
                int b_x = 2;
                int b_y = 1;
                int b_z = -7;
                double distanse = Math.Sqrt(Math.Pow(a_x - b_x, 2) + Math.Pow(a_y - b_y, 2) + Math.Pow(a_z - b_z, 2));
                Console.WriteLine(distanse);

            }


            void Z23()
            {
                int number = 9;
                for (int i = 1; i <= number; i++ )
                {
                    Console.WriteLine($"{i} * {i} * {i} ={Math.Pow(i, 3)}");
                }
            }


        Z19();
        Z21();
        Z23();
    }
    
        
    }
}
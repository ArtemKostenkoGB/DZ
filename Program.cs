using System;

namespace ConsoleApp
{
    class Programm
    {
        static void Main(string [] args)
        {
            void Z2()
            {
                int numberFirst = -9;
                int numberSecond = -3;

                if (numberFirst > numberSecond)
                {
                    Console.WriteLine("первое число больше второго");
                }
                else if (numberFirst < numberSecond)
                {
                    Console.WriteLine("второе число больше первого");
                }
                else
                {
                    Console.WriteLine("числа равны");
                }
            }
            
            void Z4()
            {
                int numberFirst = 44;
                int numberSecond = 5;
                int numberThird = 78;
                int max = numberFirst;

                if (max < numberSecond)
                {
                    max = numberSecond;
                }
                if (max < numberThird)
                {
                    max = numberThird;
                }
                Console.WriteLine(max);

            }

            void Z6()
            {
                int number = -7;
                if (number % 2 == 0) Console.WriteLine("чётное");
                else Console.WriteLine("не чётное");
            }

            void Z8()
            {
                int number = 20;
                int count = 1;
                while(count <= number)
                {
                    if (count % 2 == 0) Console.WriteLine(count);
                    count++;
                }
            }


            Z2();
            Z4();
            Z6();
            Z8();
        }

        
    }
}
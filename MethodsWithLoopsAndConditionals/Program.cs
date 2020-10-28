using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {

        static void CalcCube(int x)
        {
            Console.WriteLine($"Number is {x} and the cube of {x} is: " + x * x * x);
        }

        static void CalcSum(int[] arr)
        {
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum of your array is: " + sum);
        }

        static int[] RandomArray(int x)
        {
            int[] arr = new int[x];
            Random num = new Random();
            for (int i = 0; i < x; i++)
            {
                arr[i] = num.Next(1, 1000);
            }

            return arr;
        }


        static void MultiplicationTable(int x)
        {
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{x} times {i} equals: " + x * i);
            }
        }

        static void IsInRange(int x)
        {
            if (x >= -10 && x <= 10)
            {
                Console.WriteLine("Number is in range.");
            } else
            {
                Console.WriteLine("Number is not in range.");
            }
        }

        static void HeatinUp()
        {
            // 1. Is num between -10 and 10?
            Console.WriteLine("Enter a number: ");
            var x = Convert.ToInt32(Console.ReadLine());
            IsInRange(x);

            // 2. Multiplication table
            Console.WriteLine("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            MultiplicationTable(x);

            // 3. Random Array
            Console.WriteLine("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] arr = RandomArray(x);

            // 4. Sum of Random Array
            CalcSum(arr);

            // 5. CalcCube
            var outOfRange = true;
            do
            {
                Console.WriteLine("Enter a number between 1 and 1000");
                x = Convert.ToInt32(Console.ReadLine());
                if (x > 0 && x < 1001)
                {
                    outOfRange = false;
                    CalcCube(x);
                }
                else
                {
                    Console.WriteLine("Number not within specified range.");
                }
            } while (outOfRange == true);
        }

        static void CanVote(int x)
        {
            if (x >= 18)
            {
                Console.WriteLine("You can vote, as long as you're registered");
            } else
            {
                Console.WriteLine("You're too young to vote");
            }
        }

        static void IsPosNeg(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (x < 0)
            {
                Console.WriteLine("Number is negative");
            } else
            {
                Console.WriteLine("Number is zero.  The nature of zero is debatable.");
            }
        }

        static void IsEvenOdd(int x)
        {
            if (x % 2 != 0)
            {
                Console.WriteLine("Number is odd");
            }
            else
            {
                Console.WriteLine("Number is even");
            }
        }

        static void IsEqual(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("These numbers are equal");
            }
            else
            {
                Console.WriteLine("These numbers are not equal");
            }
        }

        static void LukeWarm()
        {
            // 1. Print all numbers 1000 to -1000
            for (int i = 1000; i > -1001; i--)
            {
                Console.WriteLine(i);
            }

            // 2. Print numbers 3 through 999 by 3s
            for (int i = 3; i < 1000; i+=3)
            {
                Console.WriteLine(i);
            }

            // 3. Accept two ints and check if they are equal
            Console.WriteLine("Enter number one: ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two: ");
            var y = Convert.ToInt32(Console.ReadLine());
            IsEqual(x, y);

            // 4. Is given int even or odd?
            Console.WriteLine("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            IsEvenOdd(x);

            // 5. Is positive or neg?
            Console.WriteLine("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            IsPosNeg(x);

            // 6. Can user vote?
            Console.WriteLine("Enter your age: ");
            x = int.Parse(Console.ReadLine());
            CanVote(x);
        }

        static void Main(string[] args)
        {
            LukeWarm();
            HeatinUp();
        }
    }
}

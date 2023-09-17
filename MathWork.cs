using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class MathWork
    {
        public void start() 
        {
            bool repeat = false;
            do
            {
                PrintMultiplicationTable();
                Calculate();
                repeat = ExitCalculation();
            }
            while (repeat);
            
        }
        private void PrintMultiplicationTable()
        {
            for (int i = 1; i < 13; i++)
            {
                for(int j = 1; j < 13; j++)
                {
                    Console.Write(String.Format("{0,4:d} ",i * j));
                }
                Console.WriteLine();
            }
        }
        private void Calculate()
        {
            int startNum=0; 
            int endNum=0;
            Console.WriteLine("\nSum numbers between any two numbers");
            Console.Write("Give number1 number: ");
            startNum = Int32.Parse(Console.ReadLine());
            Console.Write("Give end number: ");
            endNum = Int32.Parse(Console.ReadLine());
            if (startNum > endNum)
                (startNum, endNum) = (endNum, startNum);
            int sum = SumNumbers(startNum, endNum);
            Console.WriteLine($"\nThe sum of numbers between {startNum} and {endNum} is: {sum}");
            PrintEvenNumbers(startNum, endNum);
            PrintOddNumbers(startNum, endNum);
            CalculateSquareRoots(startNum, endNum);
        }
        private int SumNumbers(int startNum, int endNum)
        {
            int sum = 0;
            for (int i = startNum; i <= endNum; i++)
                sum += i;
            return sum;
        }
        private void PrintEvenNumbers(int startNum, int endNum)
        {
            Console.WriteLine($"\n****Even numbers between {startNum} and {endNum}");
            if(startNum%2 != 0)
                startNum++;
            for (int i = startNum; i <= endNum; i = i + 2)
                Console.Write($"    {i}");
        }
        private void PrintOddNumbers(int startNum, int endNum)
        {
            Console.WriteLine($"\n\n****Odd numbers between {startNum} and {endNum}");
            if (startNum % 2 == 0)
                startNum++;
            for (int i = startNum; i <= endNum; i = i + 2)
                Console.Write($"    {i}");
        }
        private void CalculateSquareRoots(int startNum, int endNum)
        {
            Console.WriteLine("\n\n\n    *********** Square roots ***********");
            for(int i = startNum; i <= endNum; i++)
            {
                Console.Write($"sqrt ( {i} to {endNum})  ");
                for(int j = i; j <= endNum; j++)
                {
                    Console.Write(string.Format("{0,6:f2}",Math.Sqrt(j)));
                }
                Console.WriteLine();
            }
        }
        private bool ExitCalculation()
        {
            bool repeat = true;
            string answer;
            Console.WriteLine("\n****Do some calculations!");
            Console.WriteLine("Exit Math work? (y/n) ");
            answer = Console.ReadLine();
            if((answer.ToUpper() == "Yes") || (answer.ToUpper() == "Y"))
                repeat = false;
            return repeat;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class WorkingShedule
    {
        public void start()
        {
            Console.WriteLine("               YOUR WORK SCHEDULE               ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            ShowMenue();

        }
        public void ShowMenue()
        {
            bool repeat=true;
            int intChoice = 0;
            Console.WriteLine(" 1 Show a list of the weekends to work.");
            Console.WriteLine(" 2 Show a list of the nights to work.");
            Console.WriteLine(" 0 Exit.");
            while (repeat)
            {
                Console.Write("\nYOUR CHOICE: ");
                string choice = Console.ReadLine();
                if (int.TryParse(choice, out intChoice))
                    repeat = false;
            }
            if (intChoice == 1)
            {
                Weekends();
                ShowMenue();
            }
            else if (intChoice == 2)
            {
                NightShifts();
                ShowMenue();
            }
            else
            {
                Console.WriteLine("Program is closing");
                return;
            }

        }
        private void Weekends()
        {
            int weekNum = 1;
            for (int i = 1; weekNum <= 52; i++)
            {
                Console.Write(string.Format("week {0,3}", weekNum));
                weekNum += 2; 

                if (i % 4 == 0)
                    Console.WriteLine();
                else
                    Console.Write("   ");
            }
            Console.WriteLine("\n-------------------------------------");
        }

        private void NightShifts()
        {
            int weekNum = 1;
            for (int i = 1; weekNum <= 52; i++)
            {
                Console.Write(string.Format("week {0,3}", weekNum));
                weekNum += 3;

                if (i % 4 == 0)
                    Console.WriteLine();
                else
                    Console.Write("   ");
            }
            Console.WriteLine("\n-------------------------------------");
        }
    }
}

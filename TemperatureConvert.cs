using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class TemperatureConvert
    {
        public void start()
        {
            ShowMenu();
        }
        private double CelsiusToFarenheit(double celsius)
        {
            double fareheit = 0;
            fareheit = 9.5 * celsius + 32;
            return fareheit;
        }
        private double FarenheitToCelsius(double farenheit)
        {
            double celsius = 0;
            celsius = 5.9 * (farenheit - 32);
            return celsius;
        }
        private void ShowMenu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("     TEMPRATUTR CONVERTOR     ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n\n  Celsius to farenhiet   :1 ");
            Console.WriteLine("\n  Farenhiet to celsius   :2 ");
            Console.WriteLine("\n  Exit                   :0 ");
            Console.WriteLine("\n\n------------------------------");
            Console.Write("Your choice: ");
            int choice = Int32.Parse(Console.ReadLine());
            if (choice == 0)
            {
                Console.WriteLine("Exiting the program.");
                return;
            }
            else 
            {
                if (choice == 1)
                {
                    ShowTableCelsiusToFareheit();
                    ShowMenu();
                }
                else if (choice == 2)
                {
                    ShowTableFareheitToCelsius();
                    ShowMenu();
                }
            }   

        }
        private void ShowTableCelsiusToFareheit() 
        {
            const int max = 100;
            for (int i = 0; i < max; i=i+4)
            { 
                Console.WriteLine(string.Format("{0, 8:f2}", i) + " C = " + string.Format("{0, 8:f2}", CelsiusToFarenheit(i)));
            }
        }
        private void ShowTableFareheitToCelsius()
        {
            const int max = 212;
            for (int i = 0; i < max; i = i + 4)
            {
                Console.WriteLine(string.Format("{0, 8:f2}", i) + " C = " + string.Format("{0, 8:f2}", FarenheitToCelsius(i)));
            }
        }
    }
}

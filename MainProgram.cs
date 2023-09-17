using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "String, selection and itiration in c#";
            FunFeatures funObj = new FunFeatures();
            funObj.start();
            ContinueToNextPart();
            Console.Title = "Let's work with Numbers!";
            MathWork calc = new MathWork();
            calc.start();
            ContinueToNextPart();
            TemperatureConvert tempObj = new TemperatureConvert();
            tempObj.start();
            ContinueToNextPart();
            WorkingShedule workObj = new WorkingShedule();
            workObj.start();
        }
        private static void ContinueToNextPart()
        {
            Console.WriteLine("\nPress Enter to continue to the NEXT PART");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

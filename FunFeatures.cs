using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class FunFeatures
    {
        private string name;
        private string email;
        private int selectedNumber;
        public void start() 
        {
            Introduce();
            bool repeat = false;
            do 
            {
                PredictMyDate();
                CalculateStrenghtLenght();
                repeat = RepeatAgain();
            }
            while (repeat);
        }
        public void Introduce() 
        {
            name = ReadName(); 
            email = ReadEmail();

            Console.WriteLine($"\n\nNice to meet you {name}");
            Console.WriteLine($"Your email is {email}");

        }

        public void PredictMyDate()
        {
            Console.WriteLine(" \n\n****** FORTUNE TELLER ******");
            Console.Write("Select a number between 1 and 7:");
            selectedNumber = Int32.Parse(Console.ReadLine());
            switch (selectedNumber)
            {
                case 1:
                    Console.WriteLine("The day is Monday, Keep calm on Mondays! You can fall apart.\n");
                    break;
                case 2:
                    Console.WriteLine("The day is Tuesdays, Tuesdays and Wednesdays break your heart!\n");
                    break;
                case 3:
                    Console.WriteLine("The day is Wednesday, Tuesdays and Wednesdays break your heart!\n");
                    break;
                case 4:
                    Console.WriteLine("The day is Thursday, Thursday is your lucky day, don't wait for Friday!\n");
                    break;
                case 5:
                    Console.WriteLine("The day is Friday, you are in love!\n");
                    break;
                case 6:
                    Console.WriteLine("The day is Saturday, do nothing and do plenty of it!\n");
                    break;
                case 7:
                    Console.WriteLine("The day is Sunday, And Sunday always comes too soon.\n");
                    break;
                default:
                    Console.WriteLine("No day? is a good day but it doesn't exist!\n");
                    break;

            }
        }
        public void CalculateStrenghtLenght()
        {
            string text;
            Console.WriteLine(" \n---- STRENGHT LENGHTH ----");
            Console.WriteLine("wrie a text with any number of characters and press Enter.");
            Console.WriteLine("You can even copy text from a file and paste it here!");
            text = Console.ReadLine();
            Console.WriteLine("\n"+text.ToUpper());
            Console.WriteLine($"Number of chars= {text.Length}");
        }
        public bool RepeatAgain()
        {
            bool repeat = false;
            string response;
            Console.Write("\nCotinue with another round? (y/n): ");
            response = Console.ReadLine();
            if ( (response.ToUpper() == "Y") || (response.ToUpper() == "YES"))
            {
                repeat = true;
            }
            return repeat;
        }

        public string ReadName() 
        {
            string firstName;
            string lastName;
            Console.WriteLine("My name is Bahareh and I am a student of the third semester!\n");
            Console.WriteLine("Let me know about yourself!");
            do {
                Console.Write("Your first name is: ");
                firstName = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(firstName));
            do
            {
                Console.Write("Your last name is: ");
                lastName = Console.ReadLine();
            } while (string.IsNullOrEmpty(lastName));
            return lastName.ToUpper()+", "+firstName;
        }

        public string ReadEmail() 
        {
            string email;
            do
            {
                Console.Write("Your email please: ");
                email = Console.ReadLine();
            } while (string.IsNullOrEmpty(email));
            return email;
                
        }
    }
}

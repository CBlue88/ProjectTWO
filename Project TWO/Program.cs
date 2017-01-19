using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TWO
{
    class Program
    {
        static void Main(string[] args)
        {
            //     int age;
            //   int month;
            string firstname;
            string lastname;



            Console.WriteLine("Welcome to the Fortune Teller program");
            Console.WriteLine("Please enter your first name");
            firstname = Console.ReadLine();   //this is a string, do not convert
            if (firstname.ToUpper() == "QUIT")
            {
                Environment.Exit(0);
            }
            else if (firstname.ToUpper() == "RESTART")
            {
                Console.Clear();
                Main(args);
                Environment.Exit(0);
            }
            Console.WriteLine("Please enter your last name"); //this is a string, do not convert
            lastname = Console.ReadLine();

            if (lastname.ToUpper() == "QUIT") //QUIT RESTART STARTS HERE
            {
                Environment.Exit(0);
            }
            else if (lastname.ToUpper() == "RESTART")
            {
                Console.Clear();
                Main(args);
                Environment.Exit(0);
            }
            Console.WriteLine(Greetingtouser(firstname, lastname));
            Console.WriteLine("Please enter your age");
            string string_age = Console.ReadLine();

            if (string_age.ToUpper() == "QUIT")
            {
                Environment.Exit(0);
            }
            else if (string_age.ToUpper() == "RESTART")
            {
                Console.Clear();
                Main(args);
                Environment.Exit(0);
            }
            int age = int.Parse(string_age);

            //Make this the igniter for restart method. 
            Console.WriteLine("Thank you for your age!");
            Console.WriteLine("Please enter the number of your birth month");
            string string_month = Console.ReadLine();
            if (string_month.ToUpper() == "QUIT")
            {
                Environment.Exit(0);
            }
            else if (string_month.ToUpper() == "RESTART")
            {
                Console.Clear();
                Main(args);
                Environment.Exit(0);
            }
            int month = int.Parse(string_month); //converts a string to INT


            Console.WriteLine("What is your favorite ROYGBIV color? If you need to know what ROYBGIV is, type \"help\"");
            string favco = Console.ReadLine();
            if (favco.ToUpper() == "QUIT")
            {
                Environment.Exit(0);
            }
            else if (favco.ToUpper() == "RESTART")
            {
                Console.Clear();
                Main(args);
                Environment.Exit(0);
            }
            else if (favco.Equals("help", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("ROYGBIV means red, orange, yellow, green, blue, and indigo \n enter your favorite color");
                favco = Console.ReadLine();

                if (favco.ToUpper() == "QUIT") //this is a string, do not convert
                {
                    Environment.Exit(0);
                }
                else if (favco.ToUpper() == "RESTART")
                {
                    Console.Clear();
                    Main(args);
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine(favco);
            }
            Console.WriteLine("How many siblings do you have? Please enter your answer as a number");
            string sibs = Console.ReadLine();
            if (sibs.ToUpper() == "QUIT")
            {
                Environment.Exit(0);
            }
            else if (sibs.ToUpper() == "RESTART")
            {
                Console.Clear();
                Main(args);
                Environment.Exit(0);
            }

            int siblings = int.Parse(sibs); //this is a string that is converted to an int


            Console.WriteLine(firstname + " " + lastname + "will retire in" + (retireyearcalc(age) + (retiremoney(month) + "in the bank, a vacation home in" + (vacationhomecalc(siblings) + "and a" + (transportcalculation(favco))))));
            Fortune_teller_response();

        }
        //YOUR METHODS START HERE FOR THIS PROJECT

        static string Greetingtouser(string first_name, string last_name)
        {

            string i = ("Greetings " + first_name + " " + last_name + " I will tell you your fortune!");

            return i;
        }

        static int retireyearcalc(int ryears)
        {
            int age = int.Parse(Console.ReadLine());
            if (age % 2 == 0)
            {
                Console.WriteLine("5");
            }
            else
            {
                Console.WriteLine("10");
            }
            return age;

        }

        static int vacationhomecalc(int sibsnumber)
        {
            int sibsnum = int.Parse(Console.ReadLine());
            if (sibsnum > 3)
            {
                Console.WriteLine(" Cleveland ");
            }
            else if (sibsnum == 0)
            {
                Console.WriteLine(" Miami ");
            }

            else if (sibsnum == 1)
            {
                Console.WriteLine(" Venice ");
            }
            else if (sibsnum == 2)
            {
                Console.WriteLine(" Chicago ");

            }

            else
            {
                Console.WriteLine(" Detroit ");
            }

            return sibsnum;
        }

        static string transportcalculation(string favoritecolor)
        {
            string favco = Console.ReadLine();
            if (favco.Equals("red", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(" Jeep ");

            }
            else if (favco.Equals("orange", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Ford Mustang");
            }
            else if (favco.Equals("yellow", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(" Dodge Truck");
            }
            else if (favco.Equals("green", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(" Schwin Bicycle");
            }
            else if (favco.Equals("blue", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(" Tesla ");
            }

            else if (favco.Equals("indigo", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(" Bugatti ");
            }
            else if (favco.Equals("violet", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(" Jaguar");
            }

            else
            {
                Console.WriteLine(" Squeaky Shopping Cart");
            }

            return favco;

        }

        static double retiremoney(int birth_month)
        {
            double rmoney;

            if (birth_month >= 1 && birth_month <= 4)
            {
                rmoney = 500000d;
            }
            else if (birth_month <= 5 && birth_month >= 8)
            {
                rmoney = 1000000d;
            }
            else if (birth_month >= 9 && birth_month <= 12)
            {
                rmoney = 250000d;
            }
            else
            {
                rmoney = 0d;
            }
            return rmoney;
        }
        static void Fortune_teller_response()
        {
            Console.WriteLine(" You have a good fortune!");
        }



    }
}

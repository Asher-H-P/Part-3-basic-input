using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_basic_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asher H.P.
            string response1, answer, response2, writeAge;
            int age;
            Console.WriteLine("Hello there");
            response1 = Console.ReadLine();
            Console.WriteLine($"You said '{response1}'. (Y/N)");
            answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
            {
                Console.WriteLine("OK");
            }
            else if (answer == "N" || answer == "n")
            {
                Console.WriteLine("What did you say then?");
                response2 = Console.ReadLine();
                Console.WriteLine($"So what you really said was '{response2}'? (Y/N)");
                answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
            {
                Console.WriteLine("OK");
            }
            else if (answer == "N" || answer == "n")
            {
                Console.WriteLine("What did you say then?");
                response2 = Console.ReadLine();
                Console.WriteLine($"So what you really said was '{response2}'? (Y/N)");
                    answer = Console.ReadLine();
                    if (answer == "Y" || answer == "y")
                    {
                        Console.WriteLine("OK");
                    }
                    else if (answer == "N" || answer == "n")
                    {
                        Console.WriteLine("What did you say then?");
                        response2 = Console.ReadLine();
                        Console.WriteLine($"So what you really said was '{response2}'? (Y/N)");
                        answer = Console.ReadLine();
                        if (answer == "Y" || answer == "y")
                        {
                            Console.WriteLine("OK");
                        }
                        else if (answer == "N" || answer == "n")
                        {
                            Console.WriteLine("What did you say then?");
                            response2 = Console.ReadLine();
                            Console.WriteLine($"So what you really said was '{response2}'? (Y/N)");
                            answer = Console.ReadLine();
                            if (answer == "Y" || answer == "y")
                            {
                                Console.WriteLine("OK");
                            }
                            else if (answer == "N" || answer == "n")
                            {
                                Console.WriteLine("What did you say then?");
                                response2 = Console.ReadLine();
                                Console.WriteLine($"So what you really said was '{response2}'? (Y/N)");
                                answer = Console.ReadLine();
                                if (answer == "Y" || answer == "y")
                                {
                                    Console.WriteLine("OK");
                                }
                                else if (answer == "N" || answer == "n")
                                {
                                    Console.WriteLine("What did you say then?");
                                    response2 = Console.ReadLine();
                                    Console.WriteLine($"So what you really said was '{response2}'? (Y/N)");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("How old are you?");
            writeAge = Console.ReadLine();
            age = Convert.ToInt32(writeAge);
            Console.WriteLine($"You are {age}.");

            Console.ReadLine();
        }
    }
}

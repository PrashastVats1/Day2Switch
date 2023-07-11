using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode, lang;
            string choice;
            do {
                Console.WriteLine("Enter Country Code");
                cCode = Console.ReadLine();
                switch (cCode)
                {
                    case "uk":
                    case "us":
                        {
                            lang = "English";
                            break;
                        }
                    case "in":
                        {
                            lang = "Hindi, English, Tamil, Punjabi, Telugu, Bihari";
                            break;
                        }
                    case "af":
                        {
                            lang = "Dari, Pashto";
                            break;
                        }
                    case "uae":
                    case "om":
                    case "eg":
                        {
                            lang = "Arabic";
                            break;
                        }
                    case "ir":
                        {
                            lang = "English, Irish";
                            break;
                        }
                    case "if":
                        {
                            lang = "Japanese";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Sorry!! Your Country Code {cCode} is not in our DB");
                            lang = "Not Found!!";
                            break;
                        }
                }
                Console.WriteLine("Country Code\t" + cCode + "\nLanguage(s)\t" + lang);
                Console.WriteLine("Do you want to continue? If yes press Y " +
                    "\n To exit press any key");
                choice = Console.ReadLine().ToUpper();
            }
            while (choice == "Y");
            Console.ReadKey();
        }
    }
}

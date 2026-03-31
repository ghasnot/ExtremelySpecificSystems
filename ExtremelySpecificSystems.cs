using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extremamenteEspecifico
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Extremely Especific System");
            Console.WriteLine("Made by Bruno Paiva");
            Console.WriteLine("");
            Console.WriteLine("Options: " +
                "\n1 - Length measurements to Smoot(s) " +
                "\n2 - ??? " +
                "\n2 - ??? " +
                "\n2 - ??? " +
                "\n2 - ??? " +
                "\n2 - ??? " +
                "\n2 - ??? " +
                "\n2 - ??? " +
                "\n2 - ??? " +
                "\n2 - ???");
            Console.WriteLine("");
            Console.WriteLine("Page 1/1");
            Console.WriteLine("");
            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option) {
                default:
                    Console.Clear();
                    Main();
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine("Welcome to the Extremely Especific System");
                    Console.WriteLine("Made by Bruno Paiva");
                    Console.WriteLine("");
                    option1();
                    break;
            }
        }

        static void option1()
        {
            float choice = 0;
            float result = 0;
            Console.WriteLine("1 - Length measurements to Smoot");
            Console.WriteLine("");
            Console.WriteLine("The smoot is a humorous, non-standard unit of length created as part of an oath of the Lambda Chi Alpha fraternity at MIT by Oliver R. Smoot, who in October 1958 repeatedly lay down on the Harvard Bridge between Boston and Cambridge, Massachusetts, so that his fraternity brothers could use his height to measure the length of the bridge.\nAn Smoot meausures approximately 1,70m (5' 6'')");
            Console.WriteLine("");

            Console.WriteLine("Lenght Measurements: " +
                "\n1 - Meters " +
                "\n2 - Centimeters " +
                "\n3 - Yards " +
                "\n4 - Foot");
            Console.WriteLine("");
            Console.Write("CHOOSE AN OPTION: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                default:
                    Console.Clear();
                    Console.WriteLine("Welcome to the Extremely Especific System");
                    Console.WriteLine("Made by Bruno Paiva");
                    Console.WriteLine("");
                    option1();
                    break;

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("How many meters? ");
                    choice = float.Parse(Console.ReadLine());
                    result = choice / 1.70f;
                    Console.WriteLine("");
                    Console.WriteLine($"The result is approximately {result:F2} smoot(s)");
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("How many centimeters? ");
                    choice = float.Parse(Console.ReadLine());
                    result = choice / 170f;
                    Console.WriteLine("");
                    Console.WriteLine($"The result is approximately {result:F2} smoot(s)");
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("How many yards? ");
                    choice = float.Parse(Console.ReadLine());
                    result = choice / 1.85f;
                    Console.WriteLine("");
                    Console.WriteLine($"The result is approximately {result:F2} smoot(s)");
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("How many foot? ");
                    choice = float.Parse(Console.ReadLine());
                    result = choice / 5.60f;
                    Console.WriteLine("");
                    Console.WriteLine($"The result is approximately {result:F2} smoot(s)");
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Wanna go back to the Main Menu? " +
                "\n1 - Yes " +
                "\n2 - No " +
                "\n3 - Retry this option");

            Console.Write("CHOOSE AN OPTION: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Clear();
                    Main();
                    break;

                case 2:
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Welcome to the Extremely Especific System");
                    Console.WriteLine("Made by Bruno Paiva");
                    Console.WriteLine("");
                    option1();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("No option was selected / Option number is wrong");
                    Console.WriteLine("System is turning off");
                    break;
            }

        }

    }
}
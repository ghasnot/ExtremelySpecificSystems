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
            Console.WriteLine("Welcome to the Extremely Specific System");
            Console.WriteLine("Made by Bruno Paiva");
            Console.WriteLine("");
            Console.WriteLine("Options: " +
                "\n1 - Length measurements to Smoot(s) " +
                "\n2 - Random Game Idea Generator " +
                "\n3 - Random French Cuss Phrase Generator " +
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

            switch (option)
            {
                default:
                    Console.Clear();
                    Main();
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine("Welcome to the Extremely Specific System");
                    Console.WriteLine("Made by Bruno Paiva");
                    Console.WriteLine("");
                    option1();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Welcome to the Extremely Specific System");
                    Console.WriteLine("Made by Bruno Paiva");
                    Console.WriteLine("");
                    option2();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Welcome to the Extremely Specific System");
                    Console.WriteLine("Made by Bruno Paiva");
                    Console.WriteLine("");
                    option3();
                    break;
            }
        }

        static void option1()
        {
            float choice = 0;
            float result = 0;
            
            //Name
            Console.WriteLine("1 - Length measurements to Smoot"); 
            Console.WriteLine("");
            
            //Description
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
                    Console.WriteLine("Welcome to the Extremely Specific System");
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
                    Console.WriteLine("Welcome to the Extremely Specific System");
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

        static void option2()
        {
            //Name
            Console.WriteLine("2 - Random Game Idea Generator"); 
            Console.WriteLine("");

            //Description
            Console.WriteLine("Do you need a cool idea for a new game but you’re struggling to think of anything interesting?"); 
            Console.WriteLine("");

            Console.WriteLine("Press ENTER to Start");
            string option = Console.ReadLine();
            Random genre = new Random();
            Random location = new Random();
            Random goal = new Random();

            int genre1 = genre.Next(1, 12);
            int location1 = genre.Next(1, 10);
            int goal1 = genre.Next(1, 10);

            string result_genre = "";
            string result_location = "";
            string result_goal = "";

            switch (genre1)
            {
                case 1:
                    result_genre = "ACTION";
                    break;

                case 2:
                    result_genre = "RPG";
                    break;

                case 3:
                    result_genre = "CASUAL";
                    break;

                case 4:
                    result_genre = "SIMULATION";
                    break;

                case 5:
                    result_genre = "STRATEGY";
                    break;

                case 6:
                    result_genre = "ADVENTURE";
                    break;

                case 7:
                    result_genre = "BATTLE ROYALE";
                    break;

                case 8:
                    result_genre = "MOBA";
                    break;

                case 9:
                    result_genre = "ROGUE-LIKE";
                    break;

                case 10:
                    result_genre = "METROID-VANIA";
                    break;

                case 11:
                    result_genre = "TURN-BASED RPG";
                    break;

                case 12:
                    result_genre = "POINT & CLICK";
                    break;
            }

            switch (location1)
            {
                case 1:
                    result_location = "a DESERT";
                    break;

                case 2:
                    result_location = "a FOREST";
                    break;

                case 3:
                    result_location = "an UNDERWATER SCENARY";
                    break;

                case 4:
                    result_location = "a VOLCANO";
                    break;

                case 5:
                    result_location = "a ZOMBIE APOCALYPSE";
                    break;

                case 6:
                    result_location = "a FARM";
                    break;

                case 7:
                    result_location = "a CAVE";
                    break;

                case 8:
                    result_location = "ANOTHER PLANET";
                    break;

                case 9:
                    result_location = "the AIR";
                    break;

                case 10:
                    result_location = "a MOUNTAIN";
                    break;
            }

            switch (goal1)
            {
                case 1:
                    result_goal = "CAPTURE A FLAG";
                    break;

                case 2:
                    result_goal = "BE THE LAST ONE STANDING";
                    break;

                case 3:
                    result_goal = "KILL ALL OF YOUR ENEMIES";
                    break;

                case 4:
                    result_goal = "TAKE CARE OF SOMEONE SPECIAL UNTIL THE END";
                    break;

                case 5:
                    result_goal = "SAVE THE WORLD";
                    break;

                case 6:
                    result_goal = "SURVIVE";
                    break;

                case 7:
                    result_goal = "MINE AND CRAFT YOUR ITEMS";
                    break;

                case 8:
                    result_goal = "EXPLORE URANUS";
                    break;

                case 9:
                    result_goal = "STOP A CATASTROPHY";
                    break;

                case 10:
                    result_goal = "BE THE PRESIDENT OF THE UNITED STATES OF AMERICA";
                    break;
            }

            Console.WriteLine($"Your game is gonna be an {result_genre} game, located on {result_location} and your goal is to {result_goal}");


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
                    Console.WriteLine("Welcome to the Extremely Specific System");
                    Console.WriteLine("Made by Bruno Paiva");
                    Console.WriteLine("");
                    option2();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("No option was selected / Option number is wrong");
                    Console.WriteLine("System is turning off");
                    break;
            }

        }

        static void option3()
        {
            //Name
            Console.WriteLine("3 - Random French Cuss Phrase Generator"); 
            Console.WriteLine("");

            //Description
            Console.WriteLine("Lighthearted text generation system designed to create humorous roasts that are entertaining while not being offensive in French."); 
            Console.WriteLine("");

            //Wait for the user to press enter
            Console.WriteLine("Press ENTER to Start");
            string option = Console.ReadLine();

            //Variables
            Random slur = new Random();
            int slur1 = slur.Next(1, 12);
            string result_slur = "";

            switch (slur1)
            {
                case 1:
                    result_slur = "Vai te faire cuire un œuf";
                    break;

                case 2:
                    result_slur = "Je te chie dans le cou";
                    break;

                case 3:
                    result_slur = "Moule à merde";
                    break;

                case 4:
                    result_slur = "Ta mère est tellement petite que sa tête pue des pieds";
                    break;

                case 5:
                    result_slur = "Pompe à chiasse";
                    break;

                case 6:
                    result_slur = "Va te faire foutre";
                    break;

                case 7:
                    result_slur = "Nique ta mère";
                    break;

                case 8:
                    result_slur = "Peau de zob";
                    break;

                case 9:
                    result_slur = "Fils de pute";
                    break;

                case 10:
                    result_slur = "Couille-molle";
                    break;

                case 11:
                    result_slur = "Espèce d’idiot";
                    break;

                case 12:
                    result_slur = "Putain de bordel de merde";
                    break;
            }

            Console.WriteLine($"Your french slur is: '{result_slur}'");


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
                    Console.WriteLine("Welcome to the Extremely Specific System");
                    Console.WriteLine("Made by Bruno Paiva");
                    Console.WriteLine("");
                    option3();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("No option was selected / Option number is wrong");
                    Console.WriteLine("System is turning off");
                    break;
            }
        }

        // MORE TO COME

    }
}

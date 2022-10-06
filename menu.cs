using System;
namespace Project_CS
{
    class Menu
    {

        // Start game  ------------------------------------------------------------------------------------------

        public static int FirstMenu()
        {
        bool correctInput = true;
        int choice = 0;
        while (correctInput)
        {
            Console.WriteLine(" |==================================================================================| ");
            Console.WriteLine("||             Are you ready to discover the secret of the king's tower?            ||");
            Console.WriteLine(" |==================================================================================| ");
            string yes = @" 
            
 ██╗       ██╗   ██╗███████╗███████╗          
███║       ╚██╗ ██╔╝██╔════╝██╔════╝ 
╚██║        ╚████╔╝ █████╗  ███████╗
 ██║         ╚██╔╝  ██╔══╝  ╚════██║
 ██║██╗       ██║   ███████╗███████║
 ╚═╝╚═╝       ╚═╝   ╚══════╝╚══════╝    ";
            Console.WriteLine(yes); 
            string no = @"
██████╗            ███╗   ██╗ ██████╗ 
╚════██╗           ████╗  ██║██╔═══██╗
 █████╔╝           ██╔██╗ ██║██║   ██║
██╔═══╝            ██║╚██╗██║██║   ██║
███████╗██╗        ██║ ╚████║╚██████╔╝
╚══════╝╚═╝        ╚═╝  ╚═══╝ ╚═════╝ ";
            Console.WriteLine(no); 

            bool Bool = int.TryParse(Console.ReadLine(), out choice);
            if (!Bool || choice <= 0 || choice > 2)
            {
                Console.WriteLine("Thats not one of the options! Try again!");
                continue;
            }
            if (choice == 1)
            {
                Console.WriteLine("You have made the right choice!!");
                string tower = @" 
            
     ██╗      ████████╗ ██████╗ ██╗    ██╗███████╗██████╗ 
     ╚██╗     ╚══██╔══╝██╔═══██╗██║    ██║██╔════╝██╔══██╗
█████╗╚██╗       ██║   ██║   ██║██║ █╗ ██║█████╗  ██████╔╝
╚════╝██╔╝       ██║   ██║   ██║██║███╗██║██╔══╝  ██╔══██╗
     ██╔╝        ██║   ╚██████╔╝╚███╔███╔╝███████╗██║  ██║
     ╚═╝         ╚═╝    ╚═════╝  ╚══╝╚══╝ ╚══════╝╚═╝  ╚═╝";
            Console.WriteLine(tower); 
                Console.ReadLine();
                Console.Clear();
                break;
            }
            if (choice == 2)
            {
                Console.WriteLine("You have abandoned your mission!! Not very glorious...");
                Environment.Exit(0);
            }
        }
        return choice;
        }

        // View player stats  -----------------------------------------------------------------------------------

        public static void Print(Person person)
        {
            person.PrintStats();
            Console.WriteLine("");
        }

        // Player's main menu  ----------------------------------------------------------------------------------

        public static int MainMenu(Player player)
        {
        bool correctInput = true;
        int choice = 0;
        int choice2 = 0;
        while (correctInput)
        {
            Console.WriteLine(" |==================================================================================| ");
            Console.WriteLine(" |                             What would you like to do?                           | ");
            Console.WriteLine(" |==================================================================================| ");
            Console.WriteLine(" |1.   Continue                                                                     |");
            Console.WriteLine(" |2.   View stats                                                                   |");
            Console.WriteLine(" |3.   Exit the game                                                                |");
            Console.WriteLine(" |==================================================================================| ");

            bool Bool = int.TryParse(Console.ReadLine(), out choice);
            if (!Bool || choice <= 0 || choice > 3)
            {
                Console.WriteLine("Thats not one of the options! Try again!");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
            if (choice == 3){
                Console.WriteLine("Are you sure ?");
                Console.WriteLine("Your progress will not be recorded");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                bool Bool2 = int.TryParse(Console.ReadLine(), out choice2);
                if (!Bool2 || choice2 > 2 || choice2 <= 0)
                {
                    Console.WriteLine("Thats not one of the options ! Try again!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (choice2 == 1)
                {
                    Console.WriteLine("You have left the game !");
                    Environment.Exit(0);
                }

                if (choice2 == 2)
                {
                    continue;
                }
            }
            if (choice == 2){
            string text = @"
    ███████╗████████╗ █████╗ ████████╗███████╗
    ██╔════╝╚══██╔══╝██╔══██╗╚══██╔══╝██╔════╝
    ███████╗   ██║   ███████║   ██║   ███████╗
    ╚════██║   ██║   ██╔══██║   ██║   ╚════██║
    ███████║   ██║   ██║  ██║   ██║   ███████║
    ╚══════╝   ╚═╝   ╚═╝  ╚═╝   ╚═╝   ╚══════╝
                                                                              ";
            Console.WriteLine(text);
                Print(player);
                Console.ReadLine();
                Console.Clear();
                continue;
            }
            if (choice == 1){
                break;
            }
        }
        return choice;
        }
    }
}

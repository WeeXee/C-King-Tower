using System;
namespace Project_CS
{
    class Fight
{

    // Game over  ----------------------------------------------------------------------

    public static void IsPlayerDead(Player player) 
    {
        if (player.life <= 0)
        {
            Console.Clear();
                string text = @"
██╗   ██╗ ██████╗ ██╗   ██╗     █████╗ ██████╗ ███████╗    ██████╗ ███████╗ █████╗ ██████╗    
╚██╗ ██╔╝██╔═══██╗██║   ██║    ██╔══██╗██╔══██╗██╔════╝    ██╔══██╗██╔════╝██╔══██╗██╔══██╗   
 ╚████╔╝ ██║   ██║██║   ██║    ███████║██████╔╝█████╗      ██║  ██║█████╗  ███████║██║  ██║   
  ╚██╔╝  ██║   ██║██║   ██║    ██╔══██║██╔══██╗██╔══╝      ██║  ██║██╔══╝  ██╔══██║██║  ██║   
   ██║   ╚██████╔╝╚██████╔╝    ██║  ██║██║  ██║███████╗    ██████╔╝███████╗██║  ██║██████╔╝██╗
   ╚═╝    ╚═════╝  ╚═════╝     ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝    ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝ ╚═╝
                            ,--.
                           {    }
                           /,   }
                          /  ~/`
                         /   /
                     {___.__/
                      `/-.__L._
                      /  ' /`\_}
                     /  ' /
             ____   /  ' /
      ,-'~~~~    ~~/  ' /_
    ,'             ``~~~  ',
   (                        Y
  {                         I
 {      -                    `,
 |       ',                   )
 |        |   ,..__      __. Y
 |    .,_./  Y ' / ^Y   J   )|
 \           |' /   |   |   ||
  \          L_/    . _ (_,.'(
   \,   ,      ^^''' / |      )
     \_  \          /,L]     /
       '-_~-,       ` `   ./`
          `'{_     ||||   )
              ^^\..___,.--`     
        
████████╗██╗  ██╗███████╗    ██╗  ██╗██╗███╗   ██╗ ██████╗     ██╗███████╗    ██████╗ ███████╗ █████╗ ██████╗    
╚══██╔══╝██║  ██║██╔════╝    ██║ ██╔╝██║████╗  ██║██╔════╝     ██║██╔════╝    ██╔══██╗██╔════╝██╔══██╗██╔══██╗   
   ██║   ███████║█████╗      █████╔╝ ██║██╔██╗ ██║██║  ███╗    ██║███████╗    ██║  ██║█████╗  ███████║██║  ██║   
   ██║   ██╔══██║██╔══╝      ██╔═██╗ ██║██║╚██╗██║██║   ██║    ██║╚════██║    ██║  ██║██╔══╝  ██╔══██║██║  ██║   
   ██║   ██║  ██║███████╗    ██║  ██╗██║██║ ╚████║╚██████╔╝    ██║███████║    ██████╔╝███████╗██║  ██║██████╔╝██╗
   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝ ╚═════╝     ╚═╝╚══════╝    ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝ ╚═╝
                                                                                                                 
                                                                              ";
        Console.WriteLine(text);
            Console.ReadLine();
            Environment.Exit(0);
        }
    }

    // View enemy and player stats  -----------------------------------------------------

    public static void PrintTheStats(Person person1 , Person person2)
    {
    string text = @"
    ███████╗████████╗ █████╗ ████████╗███████╗
    ██╔════╝╚══██╔══╝██╔══██╗╚══██╔══╝██╔════╝
    ███████╗   ██║   ███████║   ██║   ███████╗
    ╚════██║   ██║   ██╔══██║   ██║   ╚════██║
    ███████║   ██║   ██║  ██║   ██║   ███████║
    ╚══════╝   ╚═╝   ╚═╝  ╚═╝   ╚═╝   ╚══════╝
                                                                              ";
        Console.WriteLine(text);
        person1.PrintStats();
        Console.WriteLine("");
        person2.PrintStats();
        Console.WriteLine("");
    }

    // Fight between player and King Brother  --------------------------------------------

    public static void WithKingBrother(Player player , KingBrother KingBrother)
    {
        while ( KingBrother.life > 0 && player.life > 0)
        {
            PrintTheStats(KingBrother, player);

            int choice = player.YourTurn(player.FightChoice(), KingBrother);

            if (player.potion >= 0 && choice != 2 && choice != 0){
                if (KingBrother.life > 0)
                {
                    KingBrother.KingBrotherTurn(player);
                    IsPlayerDead(player);
                }
            }

        }
        Console.WriteLine("{0} was killed!" , KingBrother.name);
        player.exp += 25;
        player.HowExp();
        Console.ReadLine();
        Console.Clear();
    }

    // Fight between player and Mercenary  ----------------------------------------------

    public static void WithMercenary(Player player , Mercenary mercenary)
    {
        while (mercenary.life > 0 && player.life > 0)
        {
            PrintTheStats(mercenary, player);

            int choice = player.YourTurn(player.FightChoice(), mercenary);

            if (player.potion >= 0 && choice != 2 && choice != 0){
                if (mercenary.life > 0)
                {
                    mercenary.MercenaryTurn(player);
                    IsPlayerDead(player);
                }
            }
        }
        Console.WriteLine("{0} was killed!" , mercenary.name);
        player.exp += 10;
        player.HowExp();
        Console.ReadLine();
        Console.Clear();
    }

    // Fight between player and Dragon  ------------------------------------------------

    public static void WithDragon(Player player, Dragon dragon)
    {
        while (dragon.life > 0 && player.life > 0)
        {
            PrintTheStats(dragon, player);

            int choice = player.YourTurn(player.FightChoice(), dragon);

            if (player.potion >= 0 && choice != 2 && choice != 0){
                if (dragon.life > 0)
                {
                    dragon.DragonTurn(player);
                    IsPlayerDead(player);
                }
            }

        }
        Console.WriteLine("{0} was killed !" , dragon.name);
        player.exp += 40;
        player.HowExp();
        Console.ReadLine();
        Console.Clear();
    }

    // Fight between player and Guards  ------------------------------------------------

    public static void WithGuards(Player player, Guards guards)
    {
        while (guards.life > 0 && player.life > 0)
        {
            PrintTheStats(guards, player);

            int choice = player.YourTurn(player.FightChoice(), guards);
            if (player.potion >= 0 && choice != 2 && choice != 0){
                if (guards.life > 0)
                {
                    guards.GuardsTurn(player);
                    IsPlayerDead(player);
                }
            }

        }
        Console.WriteLine("{0} was killed !" , guards.name);
        player.exp += 10;
        player.HowExp();
        Console.ReadLine();
        Console.Clear();
    }

    // Fight between player and Snake  ------------------------------------------------

    public static void WithSnake(Player player, Snake snake)
    {
        while (snake.life > 0 && player.life > 0)
        {
            PrintTheStats(snake, player);

            int choice = player.YourTurn(player.FightChoice(), snake);
            if (player.potion >= 0 && choice != 2 && choice != 0){
                if (snake.life > 0)
                {
                    snake.SnakeTurn(player);
                    IsPlayerDead(player);
                }
            }

        }
        Console.WriteLine("{0} was killed !" , snake.name);
        player.exp += 15;
        player.HowExp();
        Console.ReadLine();
        Console.Clear();
    }
}
}
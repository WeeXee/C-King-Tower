using System;
namespace Project_CS
{
    class Program
    {
    static void Main(string[] args)
    {
        Story.Name();
        Console.WriteLine("Enter username:");
        string userName = Console.ReadLine();

        // create players and enemies

        Player player = new Player(userName, 3, 30, 1, 3);
        Mercenary mercenary = new Mercenary("Mercenary", 2, 10, 1);
        Guards guards = new Guards("Guards", 3, 15, 2);
        Snake snake = new Snake("Snake", 10, 10, 1);
        KingBrother kingbrother = new KingBrother("KingBrother", 5, 25, 5);
        Dragon dragon = new Dragon("Dragon", 7, 35, 10);

        // Story ennemy + Fight ennemy
        
        Story.Edolas();
        Menu.FirstMenu();

        Story.Mercenary();
        Menu.MainMenu(player);
        Fight.WithMercenary(player, mercenary); 

        Story.Guards();
        Menu.MainMenu(player);
        Fight.WithGuards(player, guards); 

        Story.Snake();
        Menu.MainMenu(player);
        Fight.WithSnake(player, snake); 

        Story.Brother();
        Menu.MainMenu(player);
        Fight.WithKingBrother(player, kingbrother); 

        Story.Dragon();
        Menu.MainMenu(player);
        Fight.WithDragon(player, dragon); 

        Story.TheEnd();   
    }
    } 

}
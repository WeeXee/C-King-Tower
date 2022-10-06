using System;
namespace Project_CS
{
    public class Player : Person
    {
        public int heal = 20;
        public int  Maxlife = 30;
        public int exp = 0;
        public int potion = 3;

        public Player(string _name, int _dmg , int _life, int _lvl, int _potion):base (_name , _dmg , _life, _lvl){}

        // Heal the player  --------------------------------------------------------------------------------------

        public void Heal()
        {
            life += heal;

            if (life > Maxlife)
            {
                life = Maxlife;
            }
            potion -= 1;
            Console.WriteLine("WARNING !! You have still {0} potions", potion);
        }

        // critical damage  ---------------------------------------------------------------------------------------

        public int chanceCrit() 
        {
            Random aleatoire = new Random();
		    int Chancecrit = aleatoire.Next(1, 100);
            return Chancecrit;
        }

        // choice in Fight  ---------------------------------------------------------------------------------------

        public int FightChoice()
        {
            bool correctInput = true;
            int choice = 0;
            int choice2 = 0;
            while (correctInput)
            {
                Console.WriteLine(" |==================================================================================| ");
                Console.WriteLine(" |                             Choose your fight !                                  | ");
                Console.WriteLine(" |==================================================================================| ");
                Console.WriteLine(" |1.   Attack                                                                       |");
                Console.WriteLine(" |2.   Heal (using potion)                                                          |");
                Console.WriteLine(" |3.   Abandon                                                                      |");
                Console.WriteLine(" |==================================================================================| ");

                bool Bool = int.TryParse(Console.ReadLine(), out choice);

                if (!Bool || choice <= 0 || choice > 3){
                    Console.WriteLine("Thats not one of the options! Try again!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (choice == 3){
                    Console.WriteLine("Your progress will not be recorded");
                    Console.WriteLine("Are you sure ?");
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
                        break;
                    }
                    break;
                }
                if (choice == 1 || choice == 2){
                    break;
                }
            }
            return choice;
        }

        // Player's turn  ---------------------------------------------------------------------------------------

        public int YourTurn(int choix , Enemy target)
        {
            if (choix == 1)
            {
                Console.WriteLine("You kicked the enemy!");
                if (chanceCrit() <= 85){
                    Normdmg(target);
                }else{
                    Critdmg(target);
                    Console.WriteLine("You did a hit stroke!!");
                }
                return 1;
            }

            if (choix == 2)
            {
                Console.WriteLine("Potion: {0}", potion);
                if (potion > 0){
                    Heal();
                    Console.WriteLine("You healed for {0} life!" , heal);
                }else{
                    Console.WriteLine("No potion remaining");
                    FightChoice();
                }
                return 2;
            }else{
                return 0;
            }

        }


        // Level increase  --------------------------------------------------------------------------------------

        public void LevelUp()
        {
            Console.WriteLine("You leveled up !");
            Console.WriteLine("Damage +3");
            Console.WriteLine("Max life +10");
            Console.ReadLine();

            dmg += 3;
            Maxlife += 10;
            lvl += 1;
        }

        // Player's turn  ---------------------------------------------------------------------------------------

        public void HowExp()
        {
            if (exp >= 20 && lvl == 1){
                LevelUp();
            }
            if (exp >= 50 && lvl == 2){
                LevelUp();
            }
            if (exp >= 90 && lvl == 3){
                LevelUp();
            }
            if (exp >= 130 && lvl == 4){
                LevelUp();
            }
        }
    }
}
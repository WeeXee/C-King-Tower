using System;
namespace Project_CS
{
    public class Enemy : Person
    {
        public Enemy(string _name,int _dmg, int _life, int _lvl):base (_name, _dmg , _life, _lvl){}
    }

    // KingBrother  ----------------------------------------------------------------------

    public class KingBrother : Enemy
    {
        public KingBrother(string _name, int _dmg, int _life, int _lvl):base (_name, _dmg , _life, _lvl){}

        public void KingBrotherTurn(Player target) 
        {
            Normdmg(target);
            Console.WriteLine("KingBrother punched you !");
            Console.ReadLine();
            Console.Clear();
        }
    }

    // Mercenary  -------------------------------------------------------------------------

    public class Mercenary : Enemy
    {
        public Mercenary(string _name, int _dmg, int _life, int _lvl): base(_name, _dmg, _life, _lvl){}

        public void MercenaryTurn(Player target)
        {
            Normdmg(target);
            Console.WriteLine("Mercenary punched you !");
            Console.ReadLine();
            Console.Clear();
        }
    }

    // Dragon  -----------------------------------------------------------------------------

    public class Dragon : Enemy
    {
        public Dragon (string _name, int _dmg, int _life, int _lvl):base (_name , _dmg, _life, _lvl){}

        public void DragonTurn(Player target)
        {
            Normdmg(target);
            Console.WriteLine("Dragon burned you !");
            Console.ReadLine();
            Console.Clear();
        }
    }

    // Guards  ----------------------------------------------------------------------------

    public class Guards : Enemy
    {
        public Guards (string _name, int _dmg, int _life, int _lvl):base (_name, _dmg, _life, _lvl){}

        public void GuardsTurn(Player target)
        {
            Normdmg(target);
            Console.WriteLine("Guards punched you !");
            Console.ReadLine();
            Console.Clear();
        }
    }

    // Snake  ----------------------------------------------------------------------------

    public class Snake : Enemy
    {
        public Snake (string _name, int _dmg, int _life, int _lvl):base (_name, _dmg, _life, _lvl){}

        public void SnakeTurn(Player target)
        {
            Normdmg(target);
            Console.WriteLine("Snake poisoned you !");
            Console.WriteLine("You lost 10hp because of the poison");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

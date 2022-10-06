using System;
namespace Project_CS
{
    public class Person
    {
        public string name;
        public int dmg;
        public int life;
        public int lvl;

        public Person(string _name, int _dmg, int _life, int _lvl)
        {
            name = _name;
            dmg = _dmg;
            life = _life;
            lvl = _lvl;
        }

        public void PrintStats()
        {
            Console.WriteLine("{0}:" , name);
            Console.WriteLine("");
            Console.WriteLine("Level: {0}", lvl);
            Console.WriteLine("Damage: {0}" , dmg);
            Console.WriteLine("Life: {0}", life);

        }

        public void Normdmg(Person target)
        {
            target.life -= dmg; 
        }

        public void Critdmg(Person target) 
        {
            target.life -= ((dmg + dmg) - dmg / 2);
        }
    }
}


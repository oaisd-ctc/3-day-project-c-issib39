using namespace
{
    public class Program
    {

        public static int maxHealth = 10;

        public static int health = 0;
        public static int number;

        public static void Main(string[] args)
        {

        }


        public static void Heal(int healAmount)
        {
            if ((health + healAmount) < maxHealth) { health += healAmount; Console.WriteLine($" You have {health} health now "); }

            else if ((health + healAmount) > maxHealth) { Console.WriteLine($" You can't heal past your max health "); health += healAmount; }
        }



        public static void attack()
        {
            int YesOrNo = 0;
            Random num = new Random();
            number = num.Next(1, 3);
            int monNumber = 0;
            if (1 == monNumber) { console.WriteLine($" You open the door and see no monsters. "); }
            else if (2 == number)
            {
                Console.WriteLine($" You open the door and see a monster waiting to attack you ");
                monNumber = num.Next(1, 5);
                if (monNumber == 1) { Console.WriteLine($" You that the monster is actually pretty weak "); }
                else if (2 == monNumber) { Console.WriteLine($" You see that the monster is normal "); }
                else if (3 == monNumber) { Console.WriteLine($" You see that the monster is slightly stronger than normal"); }
                else if (4 == monNumber) { Console.WriteLine($"  You see that the monster is pretty strong "); }
            }
            do
            {
                Console.WriteLine("type 1 to use attack. enter 0 to heal a little.");
                string YOrN = Console.ReadLine();
                YesOrNo = int.Parse(YOrN);
                if (YesOrNo == 1)
                {
                    HP - 3;
                    Console.WriteLine("You did 3 damage to the monster");
                }
                else
                {
                    Console.WriteLine("You healed a little your HP is at " + health;);
                    health + 2;
                }



            }
            while (HP != 0 || health != 0);
            if (HP == 0)
            {
                Console.WriteLine("YOU WON THE BATTLE!");
            }
            else
            {
                Console.WriteLine("YOU LOST YOUR WAY!");
            }
        }

    }
}
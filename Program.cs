using System;



public class Program
{

    public static int maxHealth;

    public static int health;

    public static int Sp;

    public static int maxSp;
    public static void Main(string[] args)
    {






    }

    public static void Heal(int healAmount)
    {

        if ((health + healAmount) < maxHealth) { health += healAmount; Console.WriteLine($" You have {health} health now "); }

        else if ((health + healAmount) > maxHealth) { Console.WriteLine($" You can't heal past your max health "); health += healAmount; }


    }

    public static void TakeDamage(int damage)

    {
        if ((health - damage) <= 0) { Console.WriteLine($" You Died, Game Over! "); }
        else { health -= damage; Console.WriteLine($" You took {damage} damage and have {health} left "); }

    }


    public static void RecoverSp(int SpRecoverAmount)
    {

        if ((Sp + SpRecoverAmount) >= maxSp { Console.WriteLine($" You can't recover more Sp than you have "); Sp += SpRecoverAmount; } )
        else { Sp += SpRecoverAmount; Console.WriteLine(" You have {Sp} Sp left "); }

    }


    public static void OpenDoor()
    {

        Random num = new Random();
        number = num.Next(1, 3);
        if (1 == number) { Console.WriteLine($" You open the door and see no monsters. "); }
        else if (2 == number)
        {
            Console.WriteLine($" You open the door and see a monster waiting to attack you "); Random num = new Random();
            monNumber = num.Next(1, 5); if (monNumber == 1) { Console.WriteLine($" You that the monster is actually pretty weak "); }
            else is (2 == monNumber) { Console.WriteLine($" You see that the monster is normal ");
        }
        else if (3 == monNumber) { Console.WriteLine($" You see that the monster is slightly stronger than normal"); }
        else if (4 == monNumber) { Console.WriteLine($"  You see that the monster is pretty strong "); }
    }

}
}

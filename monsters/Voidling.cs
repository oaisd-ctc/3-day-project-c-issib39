public class Voidling : monster
{
    string monsterDo = 1;
    int HP = 5;
    private static Random random = new Random();
    public static int rng(int min, int max)
    {
        return random.Next(min, max);
    }
    monsterDo = rng(1, 3);
if (monsterDo = 1)
{
damage = 1;
}
else
{
    Console.WriteLine("the" + name + "louching around.");
}
}
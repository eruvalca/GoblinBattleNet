
using GoblinBattle.MethodVersion.UI;

Goblin g1 = new();
Goblin g2 = new();

g1.SetName("Bob");
g1.SetHitPoints(10);

g2.SetName("Tom");
g2.SetHitPoints(10);

// they should take turns attacking, goblin 1 will go first
int whoseTurn = 1;

while (!g1.GetIsDead() && !g2.GetIsDead())
{
    if (whoseTurn == 1)
    {
        g1.Attack(g2);
        whoseTurn = 2;
    }
    else
    {
        g2.Attack(g1);
        whoseTurn = 1;
    }
}

Console.WriteLine("The battle is ended!");
Console.ReadLine();

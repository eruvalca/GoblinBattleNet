﻿
using GoblinBattle.PropertyVersion.UI;

Goblin g1 = new();
Goblin g2 = new();

g1.HitPoints = 10;
g1.Name = "Bob";

g2.HitPoints = 10;
g2.Name = "Tom";

// they should take turns attacking, goblin 1 will go first
int whoseTurn = 1;

while (!g1.IsDead && !g2.IsDead)
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

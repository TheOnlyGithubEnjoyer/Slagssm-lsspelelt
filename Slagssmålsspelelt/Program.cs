using System;

Fighter fighter = new Fighter();
fighter.name = "Mike Tyson";
fighter.fist = new Fists();

Fighter beast = new Fighter();
beast.name = "Connor Mcgregor";
beast.fist = new Fists();

Random generator = new Random();

while (fighter.hp > 0 && beast.hp > 0)
{
  Console.WriteLine("\n NEW ROUND");
  Console.WriteLine($"{fighter.name}: {fighter.hp} || {beast.name}: {beast.hp}\n");
  fighter.Attack(beast);
  beast.Attack(fighter);
  Console.ReadKey();
}

Console.WriteLine("\n THE FIGHT IS OVER");

if (fighter.hp == 0 && beast.hp == 0)
{
  Console.WriteLine("ITS A TIE!");
}
else if (fighter.hp == 0)
{
  Console.WriteLine($"{beast.name} WON!");
}
else
{
  Console.WriteLine($"{fighter.name} WON!");
}

Console.WriteLine("PRESS ENTER TO STOP THE FI>GHT!");
Console.ReadKey();
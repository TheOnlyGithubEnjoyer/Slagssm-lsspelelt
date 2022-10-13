using System;

Fighter fighter = new Fighter();
fighter.fist = new Fists();

Fighter beast = new Fighter();
beast.name = "Connor Mcgregor";
beast.fist = new Fists();

Random generator = new Random();


Console.WriteLine("What is you name solider?");
string fighterName;
fighterName = Console.ReadLine();
fighter.name = fighterName;

while (fighter.hp > 99 && beast.hp > 99)
{
  Console.WriteLine("\n NEW ROUND");
  Console.WriteLine($"\n {fighterName}: {fighter.hp} | {beast.name}: {beast.hp}");
  fighter.Attack(beast);
  beast.Attack(fighter);
  Console.ReadKey();
}

while (fighter.hp < 99 && beast.hp < 99 && fighter.hp > 0 && beast.hp > 0)
{
  Console.WriteLine("\n | NEXT ROUND |");
  Console.WriteLine($"\n {fighterName}: {fighter.hp} | {beast.name}: {beast.hp}");
  fighter.Attack(beast);
  beast.Attack(fighter);
  Console.ReadKey();
}


Console.WriteLine("\n | THE FIGHT IS OVER |");

if (fighter.hp == 0 && beast.hp == 0)
{
  Console.WriteLine("\n | ITS A TIE! |");
}
else if (fighter.hp == 0 && beast.hp > 0)
{
  Console.WriteLine($"\n {beast.name} WON!");
}
else if (beast.hp == 0 && fighter.hp > 0)
{
  Console.WriteLine($"\n {fighter.name} WON!");
}

Console.WriteLine("\n | PRESS ENTER TO STOP THE FIGHT! |");
Console.ReadKey();
using System;

public class Fighter
{
  public string name;
  public int hp = 100;
  public Fists fist;

  public void Attack(Fighter fighter)
  {
    int damage = fist.GetDamage();
    fighter.hp -= damage;
    fighter.hp = Math.Max(0, fighter.hp);
    Console.WriteLine($"{name} AlMOST KNOCKS OUT {fighter.name} WITH {damage}");
  }
}
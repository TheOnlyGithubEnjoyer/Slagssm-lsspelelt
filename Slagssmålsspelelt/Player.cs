using System;

public class Fighter
{
  public string name;
  public int hp = 50;
  public Fists fist;

  public void Attack(Fighter target)
  {
    int damage = fist.GetDamage();
    target.hp -= damage;
    target.hp = Math.Max(0, target.hp);
    Console.WriteLine($"{name} AlMOST KNOCKS OUT {target.name} WITH {damage}");
  }
}
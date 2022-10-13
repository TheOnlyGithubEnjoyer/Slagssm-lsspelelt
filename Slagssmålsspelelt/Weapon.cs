using System;

public class Fists
{
  public string name;
  private Random generator;

  public Fists()
  {
    generator = new Random();
  }

  public int GetDamage()
  {
    return generator.Next(10, 35);
  }
}